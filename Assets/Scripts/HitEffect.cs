using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public ParticleSystem sparksEffect;
    public float destroyDelay = 1f;

    // Метод для вызова при ударе
    public void PlayHitEffect(Vector3 position, Quaternion rotation)
    {
        if (sparksEffect != null)
        {
            // Создаем эффект в указанной позиции
            ParticleSystem effectInstance = Instantiate(sparksEffect, position, rotation);
            
            // Запускаем эффект
            effectInstance.Play();
            
            // Уничтожаем объект после завершения эффекта
            Destroy(effectInstance.gameObject, destroyDelay);
        }
    }
}
