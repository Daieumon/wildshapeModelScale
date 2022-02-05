using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using System;
using System.Text;
using TA.AI;
using TA;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using  static  ActionDefinitions ;
using  static  TA . AI . DecisionPackageDefinition ;
using  static  TA . AI . DecisionDefinition ;
using  static  RuleDefinitions ;
using  static  BanterDefinitions ;
using  static  Gui ;
using  static  BestiaryDefinitions ;
using  static  CursorDefinitions ;
using  static  AnimationDefinitions ;
using  static  CharacterClassDefinition ;
using  static  CreditsGroupDefinition ;
using  static  CampaignDefinition ;
using  static  GraphicsCharacterDefinitions ;
using  static  GameCampaignDefinitions ;
using  static  TooltipDefinitions ;
using  static  BaseBlueprint ;
using  static  MorphotypeElementDefinition ;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(HeroEquipmentOption))]
    public static partial class HeroEquipmentOptionExtensions
    {
        public static T SetDefaultChoice<T>(this T entity, System.String value)
            where T : HeroEquipmentOption
        {
            entity.SetField("defaultChoice", value);
            return entity;
        }

        public static T SetItemDefinition<T>(this T entity, ItemDefinition value)
            where T : HeroEquipmentOption
        {
            entity.SetField("itemReference", value);
            return entity;
        }

        public static T SetNumber<T>(this T entity, System.Int32 value)
            where T : HeroEquipmentOption
        {
            entity.SetField("number", value);
            return entity;
        }

        public static T SetOptionType<T>(this T entity, System.String value)
            where T : HeroEquipmentOption
        {
            entity.SetField("optionType", value);
            return entity;
        }
    }
}