﻿namespace Lemonade.Constants;

public enum FightPropType
{
    
	FightPropNone = 0,
	FightPropBaseHp = 1,
	FightPropHp = 2,
	FightPropHpPercent = 3,
	FightPropBaseAttack = 4,
	FightPropAttack = 5,
	FightPropAttackPercent = 6,
	FightPropBaseDefense = 7,
	FightPropDefense = 8,
	FightPropDefensePercent = 9,
	FightPropBaseSpeed = 10,
	FightPropSpeedPercent = 11,
	FightPropHpMpPercent = 12,
	FightPropAttackMpPercent = 13,
	FightPropCritical = 20,
	FightPropAntiCritical = 21,
	FightPropCriticalHurt = 22,
	FightPropChargeEfficiency = 23,
	FightPropAddHurt = 24,
	FightPropSubHurt = 25,
	FightPropHealAdd = 26,
	FightPropHealedAdd = 27,
	FightPropElementMastery = 28,
	FightPropPhysicalSubHurt = 29,
	FightPropPhysicalAddHurt = 30,
	FightPropDefenceIgnoreRatio = 31,
	FightPropDefenceIgnoreDelta = 32,
	FightPropFireAddHurt = 40,
	FightPropElecAddHurt = 41,
	FightPropWaterAddHurt = 42,
	FightPropGrassAddHurt = 43,
	FightPropWindAddHurt = 44,
	FightPropRockAddHurt = 45,
	FightPropIceAddHurt = 46,
	FightPropHitHeadAddHurt = 47,
	FightPropFireSubHurt = 50,
	FightPropElecSubHurt = 51,
	FightPropWaterSubHurt = 52,
	FightPropGrassSubHurt = 53,
	FightPropWindSubHurt = 54,
	FightPropRockSubHurt = 55,
	FightPropIceSubHurt = 56,
	FightPropEffectHit = 60,
	FightPropEffectResist = 61,
	FightPropFreezeResist = 62,
	FightPropDizzyResist = 64,
	FightPropFreezeShorten = 65,
	FightPropDizzyShorten = 67,
	FightPropMaxFireEnergy = 70,
	FightPropMaxElecEnergy = 71,
	FightPropMaxWaterEnergy = 72,
	FightPropMaxGrassEnergy = 73,
	FightPropMaxWindEnergy = 74,
	FightPropMaxIceEnergy = 75,
	FightPropMaxRockEnergy = 76,
	FightPropSkillCdMinusRatio = 80,
	FightPropShieldCostMinusRatio = 81,
	FightPropCurFireEnergy = 1000,
	FightPropCurElecEnergy = 1001,
	FightPropCurWaterEnergy = 1002,
	FightPropCurGrassEnergy = 1003,
	FightPropCurWindEnergy = 1004,
	FightPropCurIceEnergy = 1005,
	FightPropCurRockEnergy = 1006,
	FightPropCurHp = 1010,
	FightPropMaxHp = 2000,
	FightPropCurAttack = 2001,
	FightPropCurDefense = 2002,
	FightPropCurSpeed = 2003,
	FightPropNonextraAttack = 3000,
	FightPropNonextraDefense = 3001,
	FightPropNonextraCritical = 3002,
	FightPropNonextraAntiCritical = 3003,
	FightPropNonextraCriticalHurt = 3004,
	FightPropNonextraChargeEfficiency = 3005,
	FightPropNonextraElementMastery = 3006,
	FightPropNonextraPhysicalSubHurt = 3007,
	FightPropNonextraFireAddHurt = 3008,
	FightPropNonextraElecAddHurt = 3009,
	FightPropNonextraWaterAddHurt = 3010,
	FightPropNonextraGrassAddHurt = 3011,
	FightPropNonextraWindAddHurt = 3012,
	FightPropNonextraRockAddHurt = 3013,
	FightPropNonextraIceAddHurt = 3014,
	FightPropNonextraFireSubHurt = 3015,
	FightPropNonextraElecSubHurt = 3016,
	FightPropNonextraWaterSubHurt = 3017,
	FightPropNonextraGrassSubHurt = 3018,
	FightPropNonextraWindSubHurt = 3019,
	FightPropNonextraRockSubHurt = 3020,
	FightPropNonextraIceSubHurt = 3021,
	FightPropNonextraSkillCdMinusRatio = 3022,
	FightPropNonextraShieldCostMinusRatio = 3023,
	FightPropNonextraPhysicalAddHurt = 3024,
}