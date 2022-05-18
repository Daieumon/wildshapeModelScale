﻿using System.Collections.Generic;
using System.Linq;
using SolastaCommunityExpansion.Features;
using SolastaCommunityExpansion.Models;

namespace SolastaCommunityExpansion.Api.AdditionalExtensions;

internal static class RulesetCharacterExension
{
    public static bool IsValid(this RulesetCharacter instance, params CharacterValidator[] validators)
    {
        return validators.All(v => v(instance));
    }

    public static bool IsValid(this RulesetCharacter instance, IEnumerable<CharacterValidator> validators)
    {
        return validators == null || validators.All(v => v(instance));
    }

    /**Checks if power has enough uses and that all validators are OK*/
    public static bool CanUsePower(this RulesetCharacter instance, FeatureDefinitionPower power)
    {
        if (power == null)
        {
            return false;
        }

        if (instance.GetRemainingPowerUses(power) <= power.CostPerUse)
        {
            return false;
        }

        return power.GetAllSubFeaturesOfType<IPowerUseValidity>()
            .All(v => v.CanUsePower(instance));
    }
}