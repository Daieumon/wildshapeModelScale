﻿namespace SolastaUnfinishedBusiness.CustomInterfaces;

/**
     * Provides ways to react to attack (not spell) hits/misses
     */
internal interface IOnAttackHitEffect
{
    /**
         * Called after roll is made, but before damage is applied.
         * Called regardless of whether attack hits or not.
         */
    public void BeforeOnAttackHit(
        GameLocationCharacter attacker,
        GameLocationCharacter defender,
        RuleDefinitions.RollOutcome outcome,
        CharacterActionParams actionParams,
        RulesetAttackMode attackMode,
        ActionModifier attackModifier);

    /**
         * Called after damage is applied (or would have been applied if it was a hit).
         * Called regardless of whether attack hits or not.
         */
    public void AfterOnAttackHit(
        GameLocationCharacter attacker,
        GameLocationCharacter defender,
        RuleDefinitions.RollOutcome outcome,
        CharacterActionParams actionParams,
        RulesetAttackMode attackMode,
        ActionModifier attackModifier);
}

internal delegate void OnAttackHitDelegate(
    GameLocationCharacter attacker,
    GameLocationCharacter defender,
    RuleDefinitions.RollOutcome outcome,
    CharacterActionParams actionParams,
    RulesetAttackMode attackMode,
    ActionModifier attackModifier);
