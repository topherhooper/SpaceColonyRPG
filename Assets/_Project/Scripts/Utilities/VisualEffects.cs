using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class VisualEffects : MonoBehaviour
{
    public static VisualEffects Instance;
    
    [Header("Effect Prefabs")]
    public GameObject damageNumberPrefab;
    public GameObject levelUpEffectPrefab;
    public GameObject buildingCompleteEffectPrefab;
    public GameObject lootSparkleEffectPrefab;
    public GameObject muzzleFlashPrefab;
    public GameObject hitEffectPrefab;
    
    [Header("Effect Settings")]
    public float damageNumberDuration = 1f;
    public float damageNumberRiseSpeed = 2f;
    public AnimationCurve damageNumberCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);
    
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void ShowDamageNumber(Vector3 position, int damage, Color color)
    {
        if (damageNumberPrefab == null) return;
        
        GameObject damageNum = Instantiate(damageNumberPrefab, position, Quaternion.identity);
        
        TextMeshPro tmp = damageNum.GetComponentInChildren<TextMeshPro>();
        if (tmp != null)
        {
            tmp.text = damage.ToString();
            tmp.color = color;
        }
        else
        {
            Text text = damageNum.GetComponentInChildren<Text>();
            if (text != null)
            {
                text.text = damage.ToString();
                text.color = color;
            }
        }
        
        StartCoroutine(AnimateDamageNumber(damageNum));
    }
    
    IEnumerator AnimateDamageNumber(GameObject obj)
    {
        if (obj == null) yield break;
        
        float elapsed = 0;
        Vector3 startPos = obj.transform.position;
        Vector3 randomOffset = new Vector3(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.5f, 0.5f));
        
        TextMeshPro tmp = obj.GetComponentInChildren<TextMeshPro>();
        Text text = obj.GetComponentInChildren<Text>();
        
        while (elapsed < damageNumberDuration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / damageNumberDuration;
            
            float curveValue = damageNumberCurve.Evaluate(t);
            Vector3 pos = startPos + (Vector3.up * damageNumberRiseSpeed * curveValue) + (randomOffset * curveValue);
            obj.transform.position = pos;
            
            float alpha = 1f - t;
            if (tmp != null)
            {
                Color c = tmp.color;
                c.a = alpha;
                tmp.color = c;
            }
            else if (text != null)
            {
                Color c = text.color;
                c.a = alpha;
                text.color = c;
            }
            
            float scale = 1f + (t * 0.5f);
            obj.transform.localScale = Vector3.one * scale;
            
            yield return null;
        }
        
        Destroy(obj);
    }
    
    public void ShowLevelUpEffect(Vector3 position)
    {
        if (levelUpEffectPrefab == null) return;
        
        GameObject effect = Instantiate(levelUpEffectPrefab, position, Quaternion.identity);
        StartCoroutine(AnimateLevelUpEffect(effect));
    }
    
    IEnumerator AnimateLevelUpEffect(GameObject effect)
    {
        if (effect == null) yield break;
        
        float duration = 2f;
        float elapsed = 0;
        
        ParticleSystem ps = effect.GetComponent<ParticleSystem>();
        if (ps != null) ps.Play();
        
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            
            effect.transform.localScale = Vector3.one * (1f + t * 0.5f);
            effect.transform.Rotate(Vector3.up, 180f * Time.deltaTime);
            
            yield return null;
        }
        
        Destroy(effect);
    }
    
    public void ShowBuildingCompleteEffect(Vector3 position)
    {
        if (buildingCompleteEffectPrefab == null) return;
        
        GameObject effect = Instantiate(buildingCompleteEffectPrefab, position, Quaternion.identity);
        
        ParticleSystem ps = effect.GetComponent<ParticleSystem>();
        if (ps != null)
        {
            ps.Play();
            Destroy(effect, ps.main.duration + ps.main.startLifetime.constantMax);
        }
        else
        {
            Destroy(effect, 2f);
        }
    }
    
    public void ShowLootSparkle(Vector3 position)
    {
        if (lootSparkleEffectPrefab == null) return;
        
        GameObject effect = Instantiate(lootSparkleEffectPrefab, position, Quaternion.identity);
        
        ParticleSystem ps = effect.GetComponent<ParticleSystem>();
        if (ps != null)
        {
            ps.Play();
            Destroy(effect, ps.main.duration + ps.main.startLifetime.constantMax);
        }
        else
        {
            Destroy(effect, 1f);
        }
    }
    
    public void ShowMuzzleFlash(Vector3 position)
    {
        if (muzzleFlashPrefab == null) return;
        
        GameObject flash = Instantiate(muzzleFlashPrefab, position, Quaternion.identity);
        
        ParticleSystem ps = flash.GetComponent<ParticleSystem>();
        if (ps != null)
        {
            ps.Play();
            Destroy(flash, ps.main.duration);
        }
        else
        {
            Destroy(flash, 0.1f);
        }
    }
    
    public void ShowHitEffect(Vector3 position)
    {
        if (hitEffectPrefab == null) return;
        
        GameObject hit = Instantiate(hitEffectPrefab, position, Quaternion.identity);
        
        ParticleSystem ps = hit.GetComponent<ParticleSystem>();
        if (ps != null)
        {
            ps.Play();
            Destroy(hit, ps.main.duration + ps.main.startLifetime.constantMax);
        }
        else
        {
            Destroy(hit, 1f);
        }
    }
    
    public void ScreenShake(float intensity = 0.1f, float duration = 0.2f)
    {
        Camera mainCam = Camera.main;
        if (mainCam != null)
        {
            StartCoroutine(ShakeCamera(mainCam, intensity, duration));
        }
    }
    
    IEnumerator ShakeCamera(Camera cam, float intensity, float duration)
    {
        Vector3 originalPos = cam.transform.localPosition;
        float elapsed = 0;
        
        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            float t = elapsed / duration;
            float currentIntensity = intensity * (1f - t);
            
            float x = Random.Range(-1f, 1f) * currentIntensity;
            float y = Random.Range(-1f, 1f) * currentIntensity;
            
            cam.transform.localPosition = originalPos + new Vector3(x, y, 0);
            
            yield return null;
        }
        
        cam.transform.localPosition = originalPos;
    }
}