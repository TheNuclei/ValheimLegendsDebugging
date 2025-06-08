﻿using UnityEngine;

namespace ValheimLegends
{
    public class SE_Ranger : SE_Stats
    {
        public static Sprite AbilityIcon;
        public static GameObject GO_SEFX;

        [Header("SE_VL_Ranger")]
        public static float m_baseTTL = 2f;
        private float m_timer = 0f;
        public float hitCount = 0f;
        private float m_interval = 1f;
        private int maxHitCount = 5;

        public SE_Ranger()
        {
            base.name = "SE_VL_Ranger";
            m_icon = AbilityIcon;
            m_tooltip = "Shooty McShootface";
            m_name = "Ranger";
            m_ttl = m_baseTTL;
        }

        public override void ModifySpeed(float baseSpeed, ref float speed, Character character, Vector3 dir)
        {
            if(hitCount > 0)
            {
                speed *= 2f;
            }
            base.ModifySpeed(baseSpeed, ref speed, character, dir);
        }

        public override void OnDamaged(HitData hit, Character attacker)
        {
            hit.m_damage.m_poison *= .75f * VL_GlobalConfigs.c_rangerBonusPoisonResistance;
            base.OnDamaged(hit, attacker);
        }

        public override void ModifyRunStaminaDrain(float baseDrain, ref float drain, Vector3 dir)
        {
            drain += baseDrain * this.m_runStaminaDrainModifier;
            drain *= .75f * VL_GlobalConfigs.c_rangerBonusRunCost;
            base.ModifyRunStaminaDrain(baseDrain, ref drain, dir);
        }

        public override void UpdateStatusEffect(float dt)
        {
            m_timer -= dt;
            if (m_timer <= 0f)
            {
                m_timer = m_interval;
                hitCount--;
                hitCount = Mathf.Clamp(hitCount, 0, maxHitCount);
            }
            m_ttl = hitCount;
            m_time = 0;
            
            base.UpdateStatusEffect(dt);
        }

        public override bool IsDone()
        {
            return ValheimLegends.vl_player.vl_class != ValheimLegends.PlayerClass.Ranger;
        }

        public override bool CanAdd(Character character)
        {
            return character.IsPlayer() && ValheimLegends.vl_player.vl_class == ValheimLegends.PlayerClass.Ranger;
        }
    }
}
