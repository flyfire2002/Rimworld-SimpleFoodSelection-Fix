using System;
using UnityEngine;
using Verse;

namespace SimpleFoodSelection
{
    class SimpleFoodSelectionSettings : ModSettings
    {
        public static bool defaultHumanPrefRawTastyOverMealSurvival = true;
        public static bool humanPrefRawTastyOverMealSurvival = defaultHumanPrefRawTastyOverMealSurvival;

        public static bool defaultAsceticPrefRawTastyOverMealSurvival = true;
        public static bool asceticPrefRawTastyOverMealSurvival = defaultAsceticPrefRawTastyOverMealSurvival;

        public override void ExposeData()
        {
            Scribe_Values.Look(
                ref humanPrefRawTastyOverMealSurvival, "sfsHumanPrefRawTastyOverMealSurvival", defaultHumanPrefRawTastyOverMealSurvival);
            Scribe_Values.Look(
                ref asceticPrefRawTastyOverMealSurvival, "sfsAsceticPrefRawTastyOverMealSurvival", defaultAsceticPrefRawTastyOverMealSurvival);
            base.ExposeData();
        }
    }

    class SimpleFoodSelection : Verse.Mod
    {
        SimpleFoodSelectionSettings settings;

        public SimpleFoodSelection(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<SimpleFoodSelectionSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.CheckboxLabeled(
                "SFS_Human_RawTasty_Over_MealSurvival".Translate(),
                ref SimpleFoodSelectionSettings.humanPrefRawTastyOverMealSurvival);
            listingStandard.CheckboxLabeled(
                "SFS_Ascetic_RawTasty_Over_MealSurvival".Translate(),
                ref SimpleFoodSelectionSettings.asceticPrefRawTastyOverMealSurvival);
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "SFS_Title".Translate();
        }
    }
}