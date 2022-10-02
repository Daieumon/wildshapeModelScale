﻿namespace SolastaUnfinishedBusiness.CustomInterfaces;

internal interface IOnComputeAttackModifier
{
    public void ComputeAttackModifier(
        RulesetCharacter myself,
        RulesetCharacter defender,
        RulesetAttackMode attackMode,
        ref ActionModifier attackModifier);
}

internal delegate void OnComputeAttackModifier(
    RulesetCharacter myself,
    RulesetCharacter defender,
    RulesetAttackMode attackMode,
    ref ActionModifier attackModifier);
