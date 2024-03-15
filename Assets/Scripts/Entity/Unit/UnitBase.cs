using System;
using System.Collections.Generic;
using UnityEngine;
using UnscriptedLogic.Currency;
using UnscriptedLogic.MathUtils;

public class UnitBase : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] private float health;
    [SerializeField] private float armor;

    [Header("Movement Settings")]
    [SerializeField] private float speed = 5f;
    [SerializeField] [Range(0, 1)] private float turnSpeed = 0.5f;
    [SerializeField] private float offsetHeight;
    [SerializeField] private float stoppingDistance = 0.1f;

    [Header("Misc Settings")]
    [SerializeField] private float deathDelay = 5f;

    [Tooltip("The multiplication from the walking speed to the animation's walking speed")]
    [SerializeField] private float walkAnimMulti = 2f;
    [SerializeField] private BoxCollider boxCollider;
    [SerializeField] private Animator animator;
    [SerializeField] private DamageFlashSkinned damageFlash;

    private Vector3[] points;
    private int currentPoint = 0;

    private CurrencyHandler healthHandler;
    private CurrencyHandler speedHandler;
    private CurrencyHandler armorHandler;

    public float MaxHealth => health;
    public float CurrentHealth => healthHandler.Current;
    public float MaxSpeed => speed;
    public float CurrentSpeed => speedHandler.Current;
    public float StartArmor => armor;
    public float CurrentArmor => armorHandler.Current;

    public int CurrentWaypoint => currentPoint;
    public static event EventHandler OnAnyUnitCompletedPath;

    private void OnEnable()
    {
        points = MapManager.instance.Pathway.ToArray();

        if (points.Length != 0)
            transform.position = new Vector3(points[currentPoint].x, offsetHeight, points[currentPoint].z);

        armorHandler = new CurrencyHandler(armor);
        healthHandler = new CurrencyHandler(health, max: health);
        speedHandler = new CurrencyHandler(speed);

        healthHandler.OnEmpty += OnDeath;
        speedHandler.OnModified += (type, amount, current) => animator.speed /= Mathf.Sqrt(walkAnimMulti);
        animator.speed /= Mathf.Sqrt(walkAnimMulti);
    }

    private void Update()
    {
        if (points.Length == 0) return;

        Vector3 targetPosition = new Vector3(points[currentPoint].x, offsetHeight, points[currentPoint].z);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        transform.rotation = MathLogic.RotateSmooth(transform, targetPosition, turnSpeed);

        if (Vector3.Distance(transform.position, targetPosition) < stoppingDistance)
        {
            currentPoint++;
            if (currentPoint >= points.Length)
            {
                OnAnyUnitCompletedPath?.Invoke(this, EventArgs.Empty);
                Destroy(gameObject);
            }
        }
    }

    public void TakeDamage(float damage)
    {
        healthHandler.Modify(ModifyType.Subtract, damage);

        damageFlash.Flash();
    }

    public virtual void OnDeath()
    {
        points = new Vector3[0];
        boxCollider.enabled = false;
        animator.SetTrigger("Die");
        Destroy(gameObject, deathDelay);
    }
}