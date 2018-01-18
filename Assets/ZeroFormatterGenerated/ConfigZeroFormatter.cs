#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;
    using global::ZeroFormatter.Comparers;

    public static partial class ZeroFormatterInitializer
    {
        static bool registered = false;

        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Register()
        {
            if(registered) return;
            registered = true;
            // Enums
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Seeker.ModifierPass>.Register(new ZeroFormatter.DynamicObjectSegments.Seeker_ModifierPassFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Seeker.ModifierPass>.Register(new ZeroFormatter.DynamicObjectSegments.Seeker_ModifierPassEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Seeker.ModifierPass?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableSeeker_ModifierPassFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Seeker.ModifierPass?>.Register(new NullableEqualityComparer<global::Seeker.ModifierPass>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AstarPath.AstarDistribution>.Register(new ZeroFormatter.DynamicObjectSegments.AstarPath_AstarDistributionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AstarPath.AstarDistribution>.Register(new ZeroFormatter.DynamicObjectSegments.AstarPath_AstarDistributionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AstarPath.AstarDistribution?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableAstarPath_AstarDistributionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AstarPath.AstarDistribution?>.Register(new NullableEqualityComparer<global::AstarPath.AstarDistribution>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::BlockManager.BlockMode>.Register(new ZeroFormatter.DynamicObjectSegments.BlockManager_BlockModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::BlockManager.BlockMode>.Register(new ZeroFormatter.DynamicObjectSegments.BlockManager_BlockModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::BlockManager.BlockMode?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableBlockManager_BlockModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::BlockManager.BlockMode?>.Register(new NullableEqualityComparer<global::BlockManager.BlockMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIButtonColor.State>.Register(new ZeroFormatter.DynamicObjectSegments.UIButtonColor_StateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIButtonColor.State>.Register(new ZeroFormatter.DynamicObjectSegments.UIButtonColor_StateEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIButtonColor.State?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIButtonColor_StateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIButtonColor.State?>.Register(new NullableEqualityComparer<global::UIButtonColor.State>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIButtonMessage.Trigger>.Register(new ZeroFormatter.DynamicObjectSegments.UIButtonMessage_TriggerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIButtonMessage.Trigger>.Register(new ZeroFormatter.DynamicObjectSegments.UIButtonMessage_TriggerEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIButtonMessage.Trigger?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIButtonMessage_TriggerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIButtonMessage.Trigger?>.Register(new NullableEqualityComparer<global::UIButtonMessage.Trigger>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDragDropItem.Restriction>.Register(new ZeroFormatter.DynamicObjectSegments.UIDragDropItem_RestrictionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDragDropItem.Restriction>.Register(new ZeroFormatter.DynamicObjectSegments.UIDragDropItem_RestrictionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDragDropItem.Restriction?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIDragDropItem_RestrictionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDragDropItem.Restriction?>.Register(new NullableEqualityComparer<global::UIDragDropItem.Restriction>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDragObject.DragEffect>.Register(new ZeroFormatter.DynamicObjectSegments.UIDragObject_DragEffectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDragObject.DragEffect>.Register(new ZeroFormatter.DynamicObjectSegments.UIDragObject_DragEffectEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDragObject.DragEffect?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIDragObject_DragEffectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDragObject.DragEffect?>.Register(new NullableEqualityComparer<global::UIDragObject.DragEffect>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIGrid.Arrangement>.Register(new ZeroFormatter.DynamicObjectSegments.UIGrid_ArrangementFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIGrid.Arrangement>.Register(new ZeroFormatter.DynamicObjectSegments.UIGrid_ArrangementEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIGrid.Arrangement?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIGrid_ArrangementFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIGrid.Arrangement?>.Register(new NullableEqualityComparer<global::UIGrid.Arrangement>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIGrid.Sorting>.Register(new ZeroFormatter.DynamicObjectSegments.UIGrid_SortingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIGrid.Sorting>.Register(new ZeroFormatter.DynamicObjectSegments.UIGrid_SortingEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIGrid.Sorting?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIGrid_SortingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIGrid.Sorting?>.Register(new NullableEqualityComparer<global::UIGrid.Sorting>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIKeyBinding.Action>.Register(new ZeroFormatter.DynamicObjectSegments.UIKeyBinding_ActionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIKeyBinding.Action>.Register(new ZeroFormatter.DynamicObjectSegments.UIKeyBinding_ActionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIKeyBinding.Action?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIKeyBinding_ActionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIKeyBinding.Action?>.Register(new NullableEqualityComparer<global::UIKeyBinding.Action>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIKeyBinding.Modifier>.Register(new ZeroFormatter.DynamicObjectSegments.UIKeyBinding_ModifierFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIKeyBinding.Modifier>.Register(new ZeroFormatter.DynamicObjectSegments.UIKeyBinding_ModifierEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIKeyBinding.Modifier?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIKeyBinding_ModifierFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIKeyBinding.Modifier?>.Register(new NullableEqualityComparer<global::UIKeyBinding.Modifier>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIKeyNavigation.Constraint>.Register(new ZeroFormatter.DynamicObjectSegments.UIKeyNavigation_ConstraintFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIKeyNavigation.Constraint>.Register(new ZeroFormatter.DynamicObjectSegments.UIKeyNavigation_ConstraintEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIKeyNavigation.Constraint?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIKeyNavigation_ConstraintFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIKeyNavigation.Constraint?>.Register(new NullableEqualityComparer<global::UIKeyNavigation.Constraint>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPlaySound.Trigger>.Register(new ZeroFormatter.DynamicObjectSegments.UIPlaySound_TriggerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPlaySound.Trigger>.Register(new ZeroFormatter.DynamicObjectSegments.UIPlaySound_TriggerEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPlaySound.Trigger?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIPlaySound_TriggerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPlaySound.Trigger?>.Register(new NullableEqualityComparer<global::UIPlaySound.Trigger>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPopupList.Position>.Register(new ZeroFormatter.DynamicObjectSegments.UIPopupList_PositionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPopupList.Position>.Register(new ZeroFormatter.DynamicObjectSegments.UIPopupList_PositionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPopupList.Position?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIPopupList_PositionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPopupList.Position?>.Register(new NullableEqualityComparer<global::UIPopupList.Position>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPopupList.Selection>.Register(new ZeroFormatter.DynamicObjectSegments.UIPopupList_SelectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPopupList.Selection>.Register(new ZeroFormatter.DynamicObjectSegments.UIPopupList_SelectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPopupList.Selection?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIPopupList_SelectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPopupList.Selection?>.Register(new NullableEqualityComparer<global::UIPopupList.Selection>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPopupList.OpenOn>.Register(new ZeroFormatter.DynamicObjectSegments.UIPopupList_OpenOnFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPopupList.OpenOn>.Register(new ZeroFormatter.DynamicObjectSegments.UIPopupList_OpenOnEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPopupList.OpenOn?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIPopupList_OpenOnFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPopupList.OpenOn?>.Register(new NullableEqualityComparer<global::UIPopupList.OpenOn>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIProgressBar.FillDirection>.Register(new ZeroFormatter.DynamicObjectSegments.UIProgressBar_FillDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIProgressBar.FillDirection>.Register(new ZeroFormatter.DynamicObjectSegments.UIProgressBar_FillDirectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIProgressBar.FillDirection?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIProgressBar_FillDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIProgressBar.FillDirection?>.Register(new NullableEqualityComparer<global::UIProgressBar.FillDirection>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIScrollView.Movement>.Register(new ZeroFormatter.DynamicObjectSegments.UIScrollView_MovementFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIScrollView.Movement>.Register(new ZeroFormatter.DynamicObjectSegments.UIScrollView_MovementEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIScrollView.Movement?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIScrollView_MovementFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIScrollView.Movement?>.Register(new NullableEqualityComparer<global::UIScrollView.Movement>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIScrollView.DragEffect>.Register(new ZeroFormatter.DynamicObjectSegments.UIScrollView_DragEffectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIScrollView.DragEffect>.Register(new ZeroFormatter.DynamicObjectSegments.UIScrollView_DragEffectEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIScrollView.DragEffect?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIScrollView_DragEffectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIScrollView.DragEffect?>.Register(new NullableEqualityComparer<global::UIScrollView.DragEffect>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIScrollView.ShowCondition>.Register(new ZeroFormatter.DynamicObjectSegments.UIScrollView_ShowConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIScrollView.ShowCondition>.Register(new ZeroFormatter.DynamicObjectSegments.UIScrollView_ShowConditionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIScrollView.ShowCondition?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIScrollView_ShowConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIScrollView.ShowCondition?>.Register(new NullableEqualityComparer<global::UIScrollView.ShowCondition>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITable.Direction>.Register(new ZeroFormatter.DynamicObjectSegments.UITable_DirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITable.Direction>.Register(new ZeroFormatter.DynamicObjectSegments.UITable_DirectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITable.Direction?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUITable_DirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITable.Direction?>.Register(new NullableEqualityComparer<global::UITable.Direction>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITable.Sorting>.Register(new ZeroFormatter.DynamicObjectSegments.UITable_SortingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITable.Sorting>.Register(new ZeroFormatter.DynamicObjectSegments.UITable_SortingEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITable.Sorting?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUITable_SortingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITable.Sorting?>.Register(new NullableEqualityComparer<global::UITable.Sorting>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::NGUIText.Alignment>.Register(new ZeroFormatter.DynamicObjectSegments.NGUIText_AlignmentFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::NGUIText.Alignment>.Register(new ZeroFormatter.DynamicObjectSegments.NGUIText_AlignmentEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::NGUIText.Alignment?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableNGUIText_AlignmentFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::NGUIText.Alignment?>.Register(new NullableEqualityComparer<global::NGUIText.Alignment>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::NGUIText.SymbolStyle>.Register(new ZeroFormatter.DynamicObjectSegments.NGUIText_SymbolStyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::NGUIText.SymbolStyle>.Register(new ZeroFormatter.DynamicObjectSegments.NGUIText_SymbolStyleEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::NGUIText.SymbolStyle?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableNGUIText_SymbolStyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::NGUIText.SymbolStyle?>.Register(new NullableEqualityComparer<global::NGUIText.SymbolStyle>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::PropertyBinding.UpdateCondition>.Register(new ZeroFormatter.DynamicObjectSegments.PropertyBinding_UpdateConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::PropertyBinding.UpdateCondition>.Register(new ZeroFormatter.DynamicObjectSegments.PropertyBinding_UpdateConditionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::PropertyBinding.UpdateCondition?>.Register(new ZeroFormatter.DynamicObjectSegments.NullablePropertyBinding_UpdateConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::PropertyBinding.UpdateCondition?>.Register(new NullableEqualityComparer<global::PropertyBinding.UpdateCondition>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::PropertyBinding.Direction>.Register(new ZeroFormatter.DynamicObjectSegments.PropertyBinding_DirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::PropertyBinding.Direction>.Register(new ZeroFormatter.DynamicObjectSegments.PropertyBinding_DirectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::PropertyBinding.Direction?>.Register(new ZeroFormatter.DynamicObjectSegments.NullablePropertyBinding_DirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::PropertyBinding.Direction?>.Register(new NullableEqualityComparer<global::PropertyBinding.Direction>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.Type>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.Type>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_TypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.Type?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIBasicSprite_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.Type?>.Register(new NullableEqualityComparer<global::UIBasicSprite.Type>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.FillDirection>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_FillDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.FillDirection>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_FillDirectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.FillDirection?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIBasicSprite_FillDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.FillDirection?>.Register(new NullableEqualityComparer<global::UIBasicSprite.FillDirection>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.AdvancedType>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_AdvancedTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.AdvancedType>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_AdvancedTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.AdvancedType?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIBasicSprite_AdvancedTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.AdvancedType?>.Register(new NullableEqualityComparer<global::UIBasicSprite.AdvancedType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.Flip>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_FlipFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.Flip>.Register(new ZeroFormatter.DynamicObjectSegments.UIBasicSprite_FlipEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIBasicSprite.Flip?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIBasicSprite_FlipFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIBasicSprite.Flip?>.Register(new NullableEqualityComparer<global::UIBasicSprite.Flip>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDrawCall.Clipping>.Register(new ZeroFormatter.DynamicObjectSegments.UIDrawCall_ClippingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDrawCall.Clipping>.Register(new ZeroFormatter.DynamicObjectSegments.UIDrawCall_ClippingEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDrawCall.Clipping?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIDrawCall_ClippingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDrawCall.Clipping?>.Register(new NullableEqualityComparer<global::UIDrawCall.Clipping>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDrawCall.ShadowMode>.Register(new ZeroFormatter.DynamicObjectSegments.UIDrawCall_ShadowModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDrawCall.ShadowMode>.Register(new ZeroFormatter.DynamicObjectSegments.UIDrawCall_ShadowModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIDrawCall.ShadowMode?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIDrawCall_ShadowModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIDrawCall.ShadowMode?>.Register(new NullableEqualityComparer<global::UIDrawCall.ShadowMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIRect.AnchorUpdate>.Register(new ZeroFormatter.DynamicObjectSegments.UIRect_AnchorUpdateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIRect.AnchorUpdate>.Register(new ZeroFormatter.DynamicObjectSegments.UIRect_AnchorUpdateEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIRect.AnchorUpdate?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIRect_AnchorUpdateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIRect.AnchorUpdate?>.Register(new NullableEqualityComparer<global::UIRect.AnchorUpdate>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIWidget.Pivot>.Register(new ZeroFormatter.DynamicObjectSegments.UIWidget_PivotFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIWidget.Pivot>.Register(new ZeroFormatter.DynamicObjectSegments.UIWidget_PivotEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIWidget.Pivot?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIWidget_PivotFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIWidget.Pivot?>.Register(new NullableEqualityComparer<global::UIWidget.Pivot>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIWidget.AspectRatioSource>.Register(new ZeroFormatter.DynamicObjectSegments.UIWidget_AspectRatioSourceFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIWidget.AspectRatioSource>.Register(new ZeroFormatter.DynamicObjectSegments.UIWidget_AspectRatioSourceEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIWidget.AspectRatioSource?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIWidget_AspectRatioSourceFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIWidget.AspectRatioSource?>.Register(new NullableEqualityComparer<global::UIWidget.AspectRatioSource>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::TweenLetters.AnimationLetterOrder>.Register(new ZeroFormatter.DynamicObjectSegments.TweenLetters_AnimationLetterOrderFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::TweenLetters.AnimationLetterOrder>.Register(new ZeroFormatter.DynamicObjectSegments.TweenLetters_AnimationLetterOrderEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::TweenLetters.AnimationLetterOrder?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableTweenLetters_AnimationLetterOrderFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::TweenLetters.AnimationLetterOrder?>.Register(new NullableEqualityComparer<global::TweenLetters.AnimationLetterOrder>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITweener.Method>.Register(new ZeroFormatter.DynamicObjectSegments.UITweener_MethodFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITweener.Method>.Register(new ZeroFormatter.DynamicObjectSegments.UITweener_MethodEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITweener.Method?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUITweener_MethodFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITweener.Method?>.Register(new NullableEqualityComparer<global::UITweener.Method>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITweener.Style>.Register(new ZeroFormatter.DynamicObjectSegments.UITweener_StyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITweener.Style>.Register(new ZeroFormatter.DynamicObjectSegments.UITweener_StyleEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITweener.Style?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUITweener_StyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITweener.Style?>.Register(new NullableEqualityComparer<global::UITweener.Style>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIAnchor.Side>.Register(new ZeroFormatter.DynamicObjectSegments.UIAnchor_SideFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIAnchor.Side>.Register(new ZeroFormatter.DynamicObjectSegments.UIAnchor_SideEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIAnchor.Side?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIAnchor_SideFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIAnchor.Side?>.Register(new NullableEqualityComparer<global::UIAnchor.Side>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.ControlScheme>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_ControlSchemeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.ControlScheme>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_ControlSchemeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.ControlScheme?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUICamera_ControlSchemeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.ControlScheme?>.Register(new NullableEqualityComparer<global::UICamera.ControlScheme>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.ClickNotification>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_ClickNotificationFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.ClickNotification>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_ClickNotificationEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.ClickNotification?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUICamera_ClickNotificationFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.ClickNotification?>.Register(new NullableEqualityComparer<global::UICamera.ClickNotification>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.EventType>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_EventTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.EventType>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_EventTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.EventType?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUICamera_EventTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.EventType?>.Register(new NullableEqualityComparer<global::UICamera.EventType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.ProcessEventsIn>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_ProcessEventsInFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.ProcessEventsIn>.Register(new ZeroFormatter.DynamicObjectSegments.UICamera_ProcessEventsInEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UICamera.ProcessEventsIn?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUICamera_ProcessEventsInFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UICamera.ProcessEventsIn?>.Register(new NullableEqualityComparer<global::UICamera.ProcessEventsIn>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.InputType>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_InputTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.InputType>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_InputTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.InputType?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIInput_InputTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.InputType?>.Register(new NullableEqualityComparer<global::UIInput.InputType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.Validation>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_ValidationFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.Validation>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_ValidationEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.Validation?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIInput_ValidationFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.Validation?>.Register(new NullableEqualityComparer<global::UIInput.Validation>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.KeyboardType>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_KeyboardTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.KeyboardType>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_KeyboardTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.KeyboardType?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIInput_KeyboardTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.KeyboardType?>.Register(new NullableEqualityComparer<global::UIInput.KeyboardType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.OnReturnKey>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_OnReturnKeyFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.OnReturnKey>.Register(new ZeroFormatter.DynamicObjectSegments.UIInput_OnReturnKeyEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIInput.OnReturnKey?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIInput_OnReturnKeyFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIInput.OnReturnKey?>.Register(new NullableEqualityComparer<global::UIInput.OnReturnKey>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Effect>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_EffectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Effect>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_EffectEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Effect?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUILabel_EffectFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Effect?>.Register(new NullableEqualityComparer<global::UILabel.Effect>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Overflow>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_OverflowFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Overflow>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_OverflowEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Overflow?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUILabel_OverflowFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Overflow?>.Register(new NullableEqualityComparer<global::UILabel.Overflow>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Crispness>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_CrispnessFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Crispness>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_CrispnessEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Crispness?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUILabel_CrispnessFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Crispness?>.Register(new NullableEqualityComparer<global::UILabel.Crispness>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Modifier>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_ModifierFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Modifier>.Register(new ZeroFormatter.DynamicObjectSegments.UILabel_ModifierEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UILabel.Modifier?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUILabel_ModifierFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UILabel.Modifier?>.Register(new NullableEqualityComparer<global::UILabel.Modifier>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPanel.RenderQueue>.Register(new ZeroFormatter.DynamicObjectSegments.UIPanel_RenderQueueFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPanel.RenderQueue>.Register(new ZeroFormatter.DynamicObjectSegments.UIPanel_RenderQueueEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIPanel.RenderQueue?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIPanel_RenderQueueFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIPanel.RenderQueue?>.Register(new NullableEqualityComparer<global::UIPanel.RenderQueue>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIRoot.Scaling>.Register(new ZeroFormatter.DynamicObjectSegments.UIRoot_ScalingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIRoot.Scaling>.Register(new ZeroFormatter.DynamicObjectSegments.UIRoot_ScalingEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIRoot.Scaling?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIRoot_ScalingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIRoot.Scaling?>.Register(new NullableEqualityComparer<global::UIRoot.Scaling>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIRoot.Constraint>.Register(new ZeroFormatter.DynamicObjectSegments.UIRoot_ConstraintFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIRoot.Constraint>.Register(new ZeroFormatter.DynamicObjectSegments.UIRoot_ConstraintEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIRoot.Constraint?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIRoot_ConstraintFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIRoot.Constraint?>.Register(new NullableEqualityComparer<global::UIRoot.Constraint>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIStretch.Style>.Register(new ZeroFormatter.DynamicObjectSegments.UIStretch_StyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIStretch.Style>.Register(new ZeroFormatter.DynamicObjectSegments.UIStretch_StyleEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UIStretch.Style?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUIStretch_StyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UIStretch.Style?>.Register(new NullableEqualityComparer<global::UIStretch.Style>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITextList.Style>.Register(new ZeroFormatter.DynamicObjectSegments.UITextList_StyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITextList.Style>.Register(new ZeroFormatter.DynamicObjectSegments.UITextList_StyleEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UITextList.Style?>.Register(new ZeroFormatter.DynamicObjectSegments.NullableUITextList_StyleFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UITextList.Style?>.Register(new NullableEqualityComparer<global::UITextList.Style>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraSettings.ProjectionType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraSettings_ProjectionTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraSettings.ProjectionType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraSettings_ProjectionTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraSettings.ProjectionType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dCameraSettings_ProjectionTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraSettings.ProjectionType?>.Register(new NullableEqualityComparer<global::tk2dCameraSettings.ProjectionType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraSettings.OrthographicType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraSettings_OrthographicTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraSettings.OrthographicType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraSettings_OrthographicTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraSettings.OrthographicType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dCameraSettings_OrthographicTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraSettings.OrthographicType?>.Register(new NullableEqualityComparer<global::tk2dCameraSettings.OrthographicType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraSettings.OrthographicOrigin>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraSettings_OrthographicOriginFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraSettings.OrthographicOrigin>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraSettings_OrthographicOriginEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraSettings.OrthographicOrigin?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dCameraSettings_OrthographicOriginFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraSettings.OrthographicOrigin?>.Register(new NullableEqualityComparer<global::tk2dCameraSettings.OrthographicOrigin>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraResolutionOverride.MatchByType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraResolutionOverride_MatchByTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraResolutionOverride.MatchByType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraResolutionOverride_MatchByTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraResolutionOverride.MatchByType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dCameraResolutionOverride_MatchByTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraResolutionOverride.MatchByType?>.Register(new NullableEqualityComparer<global::tk2dCameraResolutionOverride.MatchByType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraResolutionOverride.AutoScaleMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraResolutionOverride_AutoScaleModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraResolutionOverride.AutoScaleMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraResolutionOverride_AutoScaleModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraResolutionOverride.AutoScaleMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dCameraResolutionOverride_AutoScaleModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraResolutionOverride.AutoScaleMode?>.Register(new NullableEqualityComparer<global::tk2dCameraResolutionOverride.AutoScaleMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraResolutionOverride.FitMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraResolutionOverride_FitModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraResolutionOverride.FitMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dCameraResolutionOverride_FitModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dCameraResolutionOverride.FitMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dCameraResolutionOverride_FitModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dCameraResolutionOverride.FitMode?>.Register(new NullableEqualityComparer<global::tk2dCameraResolutionOverride.FitMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dBaseSprite.Anchor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dBaseSprite_AnchorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dBaseSprite.Anchor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dBaseSprite_AnchorEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dBaseSprite.Anchor?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dBaseSprite_AnchorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dBaseSprite.Anchor?>.Register(new NullableEqualityComparer<global::tk2dBaseSprite.Anchor>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteAnimationClip.WrapMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteAnimationClip_WrapModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteAnimationClip.WrapMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteAnimationClip_WrapModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteAnimationClip.WrapMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteAnimationClip_WrapModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteAnimationClip.WrapMode?>.Register(new NullableEqualityComparer<global::tk2dSpriteAnimationClip.WrapMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.Anchor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_AnchorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.Anchor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_AnchorEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.Anchor?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_AnchorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.Anchor?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.Anchor>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.Pad>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_PadFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.Pad>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_PadEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.Pad?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_PadFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.Pad?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.Pad>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.ColliderType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_ColliderTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_ColliderTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.ColliderType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_ColliderTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderType?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.PolygonColliderCap>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_PolygonColliderCapFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.PolygonColliderCap>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_PolygonColliderCapEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.PolygonColliderCap?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_PolygonColliderCapFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.PolygonColliderCap?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.PolygonColliderCap>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.ColliderColor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_ColliderColorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderColor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_ColliderColorEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.ColliderColor?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_ColliderColorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderColor?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderColor>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.Source>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_SourceFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.Source>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_SourceEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.Source?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_SourceFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.Source?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.Source>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.DiceFilter>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_DiceFilterFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.DiceFilter>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_DiceFilterEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.DiceFilter?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_DiceFilterFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.DiceFilter?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.DiceFilter>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.ColliderData.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_ColliderData_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderData.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionDefinition_ColliderData_TypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionDefinition.ColliderData.Type?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionDefinition_ColliderData_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderData.Type?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderData.Type>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteSheetSource.Anchor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteSheetSource_AnchorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteSheetSource.Anchor>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteSheetSource_AnchorEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteSheetSource.Anchor?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteSheetSource_AnchorFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteSheetSource.Anchor?>.Register(new NullableEqualityComparer<global::tk2dSpriteSheetSource.Anchor>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteSheetSource.SplitMethod>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteSheetSource_SplitMethodFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteSheetSource.SplitMethod>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteSheetSource_SplitMethodEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteSheetSource.SplitMethod?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteSheetSource_SplitMethodFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteSheetSource.SplitMethod?>.Register(new NullableEqualityComparer<global::tk2dSpriteSheetSource.SplitMethod>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollection.NormalGenerationMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollection_NormalGenerationModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollection.NormalGenerationMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollection_NormalGenerationModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollection.NormalGenerationMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollection_NormalGenerationModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollection.NormalGenerationMode?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollection.NormalGenerationMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollection.TextureCompression>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollection_TextureCompressionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollection.TextureCompression>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollection_TextureCompressionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollection.TextureCompression?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollection_TextureCompressionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollection.TextureCompression?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollection.TextureCompression>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollection.AtlasFormat>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollection_AtlasFormatFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollection.AtlasFormat>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollection_AtlasFormatEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollection.AtlasFormat?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollection_AtlasFormatFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollection.AtlasFormat?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollection.AtlasFormat>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteColliderDefinition.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteColliderDefinition_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteColliderDefinition.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteColliderDefinition_TypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteColliderDefinition.Type?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteColliderDefinition_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteColliderDefinition.Type?>.Register(new NullableEqualityComparer<global::tk2dSpriteColliderDefinition.Type>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteDefinition.ColliderType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteDefinition_ColliderTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteDefinition.ColliderType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteDefinition_ColliderTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteDefinition.ColliderType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteDefinition_ColliderTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteDefinition.ColliderType?>.Register(new NullableEqualityComparer<global::tk2dSpriteDefinition.ColliderType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteDefinition.PhysicsEngine>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteDefinition_PhysicsEngineFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteDefinition.PhysicsEngine>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteDefinition_PhysicsEngineEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteDefinition.PhysicsEngine?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteDefinition_PhysicsEngineFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteDefinition.PhysicsEngine?>.Register(new NullableEqualityComparer<global::tk2dSpriteDefinition.PhysicsEngine>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteDefinition.FlipMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteDefinition_FlipModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteDefinition.FlipMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteDefinition_FlipModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteDefinition.FlipMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteDefinition_FlipModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteDefinition.FlipMode?>.Register(new NullableEqualityComparer<global::tk2dSpriteDefinition.FlipMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionSize.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionSize_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionSize.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dSpriteCollectionSize_TypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dSpriteCollectionSize.Type?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dSpriteCollectionSize_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dSpriteCollectionSize.Type?>.Register(new NullableEqualityComparer<global::tk2dSpriteCollectionSize.Type>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dBatchedSprite.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dBatchedSprite_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dBatchedSprite.Type>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dBatchedSprite_TypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dBatchedSprite.Type?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dBatchedSprite_TypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dBatchedSprite.Type?>.Register(new NullableEqualityComparer<global::tk2dBatchedSprite.Type>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dBatchedSprite.Flags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dBatchedSprite_FlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dBatchedSprite.Flags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dBatchedSprite_FlagsEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dBatchedSprite.Flags?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dBatchedSprite_FlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dBatchedSprite.Flags?>.Register(new NullableEqualityComparer<global::tk2dBatchedSprite.Flags>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dStaticSpriteBatcher.Flags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dStaticSpriteBatcher_FlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dStaticSpriteBatcher.Flags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dStaticSpriteBatcher_FlagsEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dStaticSpriteBatcher.Flags?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dStaticSpriteBatcher_FlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dStaticSpriteBatcher.Flags?>.Register(new NullableEqualityComparer<global::tk2dStaticSpriteBatcher.Flags>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileFlags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileFlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileFlags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileFlagsEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileFlags?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dTileFlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileFlags?>.Register(new NullableEqualityComparer<global::tk2dTileFlags>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMap.BuildFlags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMap_BuildFlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMap.BuildFlags>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMap_BuildFlagsEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMap.BuildFlags?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dTileMap_BuildFlagsFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMap.BuildFlags?>.Register(new NullableEqualityComparer<global::tk2dTileMap.BuildFlags>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMapData.SortMethod>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMapData_SortMethodFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMapData.SortMethod>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMapData_SortMethodEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMapData.SortMethod?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dTileMapData_SortMethodFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMapData.SortMethod?>.Register(new NullableEqualityComparer<global::tk2dTileMapData.SortMethod>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMapData.TileType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMapData_TileTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMapData.TileType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMapData_TileTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMapData.TileType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dTileMapData_TileTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMapData.TileType?>.Register(new NullableEqualityComparer<global::tk2dTileMapData.TileType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMapData.ColorMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMapData_ColorModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMapData.ColorMode>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dTileMapData_ColorModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dTileMapData.ColorMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dTileMapData_ColorModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dTileMapData.ColorMode?>.Register(new NullableEqualityComparer<global::tk2dTileMapData.ColorMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dUIScrollableArea.Axes>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dUIScrollableArea_AxesFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dUIScrollableArea.Axes>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dUIScrollableArea_AxesEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dUIScrollableArea.Axes?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dUIScrollableArea_AxesFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dUIScrollableArea.Axes?>.Register(new NullableEqualityComparer<global::tk2dUIScrollableArea.Axes>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dUIScrollbar.Axes>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dUIScrollbar_AxesFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dUIScrollbar.Axes>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dUIScrollbar_AxesEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dUIScrollbar.Axes?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dUIScrollbar_AxesFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dUIScrollbar.Axes?>.Register(new NullableEqualityComparer<global::tk2dUIScrollbar.Axes>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dUICamera.tk2dRaycastType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dUICamera_tk2dRaycastTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dUICamera.tk2dRaycastType>.Register(new ZeroFormatter.DynamicObjectSegments.tk2dUICamera_tk2dRaycastTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::tk2dUICamera.tk2dRaycastType?>.Register(new ZeroFormatter.DynamicObjectSegments.Nullabletk2dUICamera_tk2dRaycastTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::tk2dUICamera.tk2dRaycastType?>.Register(new NullableEqualityComparer<global::tk2dUICamera.tk2dRaycastType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.Trigger>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.TriggerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.Trigger>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.TriggerEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.Trigger?>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.NullableTriggerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.Trigger?>.Register(new NullableEqualityComparer<global::AnimationOrTween.Trigger>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.Direction>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.DirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.Direction>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.DirectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.Direction?>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.NullableDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.Direction?>.Register(new NullableEqualityComparer<global::AnimationOrTween.Direction>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.EnableCondition>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.EnableConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.EnableCondition>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.EnableConditionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.EnableCondition?>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.NullableEnableConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.EnableCondition?>.Register(new NullableEqualityComparer<global::AnimationOrTween.EnableCondition>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.DisableCondition>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.DisableConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.DisableCondition>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.DisableConditionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::AnimationOrTween.DisableCondition?>.Register(new ZeroFormatter.DynamicObjectSegments.AnimationOrTween.NullableDisableConditionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::AnimationOrTween.DisableCondition?>.Register(new NullableEqualityComparer<global::AnimationOrTween.DisableCondition>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::MessagePack.TinyJsonToken>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.TinyJsonTokenFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::MessagePack.TinyJsonToken>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.TinyJsonTokenEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::MessagePack.TinyJsonToken?>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.NullableTinyJsonTokenFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::MessagePack.TinyJsonToken?>.Register(new NullableEqualityComparer<global::MessagePack.TinyJsonToken>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::MessagePack.ValueType>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.ValueTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::MessagePack.ValueType>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.ValueTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::MessagePack.ValueType?>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.NullableValueTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::MessagePack.ValueType?>.Register(new NullableEqualityComparer<global::MessagePack.ValueType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::MessagePack.MessagePackType>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.MessagePackTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::MessagePack.MessagePackType>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.MessagePackTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::MessagePack.MessagePackType?>.Register(new ZeroFormatter.DynamicObjectSegments.MessagePack.NullableMessagePackTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::MessagePack.MessagePackType?>.Register(new NullableEqualityComparer<global::MessagePack.MessagePackType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GraphUpdateThreading>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GraphUpdateThreadingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GraphUpdateThreading>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GraphUpdateThreadingEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GraphUpdateThreading?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableGraphUpdateThreadingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GraphUpdateThreading?>.Register(new NullableEqualityComparer<global::Pathfinding.GraphUpdateThreading>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.PathLog>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.PathLogFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.PathLog>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.PathLogEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.PathLog?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullablePathLogFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.PathLog?>.Register(new NullableEqualityComparer<global::Pathfinding.PathLog>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.Heuristic>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.HeuristicFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.Heuristic>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.HeuristicEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.Heuristic?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableHeuristicFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.Heuristic?>.Register(new NullableEqualityComparer<global::Pathfinding.Heuristic>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GraphDebugMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GraphDebugModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GraphDebugMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GraphDebugModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GraphDebugMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableGraphDebugModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GraphDebugMode?>.Register(new NullableEqualityComparer<global::Pathfinding.GraphDebugMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.ThreadCount>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.ThreadCountFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.ThreadCount>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.ThreadCountEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.ThreadCount?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableThreadCountFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.ThreadCount?>.Register(new NullableEqualityComparer<global::Pathfinding.ThreadCount>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.PathState>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.PathStateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.PathState>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.PathStateEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.PathState?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullablePathStateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.PathState?>.Register(new NullableEqualityComparer<global::Pathfinding.PathState>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.PathCompleteState>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.PathCompleteStateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.PathCompleteState>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.PathCompleteStateEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.PathCompleteState?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullablePathCompleteStateFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.PathCompleteState?>.Register(new NullableEqualityComparer<global::Pathfinding.PathCompleteState>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GraphModifier.EventType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GraphModifier_EventTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GraphModifier.EventType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GraphModifier_EventTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GraphModifier.EventType?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableGraphModifier_EventTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GraphModifier.EventType?>.Register(new NullableEqualityComparer<global::Pathfinding.GraphModifier.EventType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.ColliderType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.ColliderTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.ColliderType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.ColliderTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.ColliderType?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableColliderTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.ColliderType?>.Register(new NullableEqualityComparer<global::Pathfinding.ColliderType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RayDirection>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RayDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RayDirection>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RayDirectionEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RayDirection?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableRayDirectionFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RayDirection?>.Register(new NullableEqualityComparer<global::Pathfinding.RayDirection>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GridGraph.TextureData.ChannelUse>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GridGraph_TextureData_ChannelUseFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GridGraph.TextureData.ChannelUse>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.GridGraph_TextureData_ChannelUseEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.GridGraph.TextureData.ChannelUse?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableGridGraph_TextureData_ChannelUseFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.GridGraph.TextureData.ChannelUse?>.Register(new NullableEqualityComparer<global::Pathfinding.GridGraph.TextureData.ChannelUse>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.NumNeighbours>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NumNeighboursFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.NumNeighbours>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NumNeighboursEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.NumNeighbours?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableNumNeighboursFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.NumNeighbours?>.Register(new NullableEqualityComparer<global::Pathfinding.NumNeighbours>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RecastGraph_RelevantGraphSurfaceModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RecastGraph_RelevantGraphSurfaceModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableRecastGraph_RelevantGraphSurfaceModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode?>.Register(new NullableEqualityComparer<global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.HeuristicOptimizationMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.HeuristicOptimizationModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.HeuristicOptimizationMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.HeuristicOptimizationModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.HeuristicOptimizationMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableHeuristicOptimizationModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.HeuristicOptimizationMode?>.Register(new NullableEqualityComparer<global::Pathfinding.HeuristicOptimizationMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.SimpleSmoothModifier.SmoothType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.SimpleSmoothModifier_SmoothTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.SimpleSmoothModifier.SmoothType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.SimpleSmoothModifier_SmoothTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.SimpleSmoothModifier.SmoothType?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableSimpleSmoothModifier_SmoothTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.SimpleSmoothModifier.SmoothType?>.Register(new NullableEqualityComparer<global::Pathfinding.SimpleSmoothModifier.SmoothType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.StartEndModifier.Exactness>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.StartEndModifier_ExactnessFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.StartEndModifier.Exactness>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.StartEndModifier_ExactnessEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.StartEndModifier.Exactness?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableStartEndModifier_ExactnessFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.StartEndModifier.Exactness?>.Register(new NullableEqualityComparer<global::Pathfinding.StartEndModifier.Exactness>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.NavmeshAdd.MeshType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NavmeshAdd_MeshTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.NavmeshAdd.MeshType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NavmeshAdd_MeshTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.NavmeshAdd.MeshType?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableNavmeshAdd_MeshTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.NavmeshAdd.MeshType?>.Register(new NullableEqualityComparer<global::Pathfinding.NavmeshAdd.MeshType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.NavmeshCut.MeshType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NavmeshCut_MeshTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.NavmeshCut.MeshType>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NavmeshCut_MeshTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.NavmeshCut.MeshType?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableNavmeshCut_MeshTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.NavmeshCut.MeshType?>.Register(new NullableEqualityComparer<global::Pathfinding.NavmeshCut.MeshType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.MultiTargetPath.HeuristicMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.MultiTargetPath_HeuristicModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.MultiTargetPath.HeuristicMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.MultiTargetPath_HeuristicModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.MultiTargetPath.HeuristicMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.NullableMultiTargetPath_HeuristicModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.MultiTargetPath.HeuristicMode?>.Register(new NullableEqualityComparer<global::Pathfinding.MultiTargetPath.HeuristicMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RVO.MovementPlane>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.MovementPlaneFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RVO.MovementPlane>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.MovementPlaneEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RVO.MovementPlane?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.NullableMovementPlaneFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RVO.MovementPlane?>.Register(new NullableEqualityComparer<global::Pathfinding.RVO.MovementPlane>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RVO.RVOLayer>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.RVOLayerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RVO.RVOLayer>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.RVOLayerEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RVO.RVOLayer?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.NullableRVOLayerFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RVO.RVOLayer?>.Register(new NullableEqualityComparer<global::Pathfinding.RVO.RVOLayer>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.RVOObstacle_ObstacleVertexWindingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.RVOObstacle_ObstacleVertexWindingEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO.NullableRVOObstacle_ObstacleVertexWindingFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding?>.Register(new NullableEqualityComparer<global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.Util.TileHandler.CutMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.Util.TileHandler_CutModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.Util.TileHandler.CutMode>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.Util.TileHandler_CutModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::Pathfinding.Util.TileHandler.CutMode?>.Register(new ZeroFormatter.DynamicObjectSegments.Pathfinding.Util.NullableTileHandler_CutModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::Pathfinding.Util.TileHandler.CutMode?>.Register(new NullableEqualityComparer<global::Pathfinding.Util.TileHandler.CutMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.NotificationKind>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NotificationKindFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.NotificationKind>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NotificationKindEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.NotificationKind?>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NullableNotificationKindFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.NotificationKind?>.Register(new NullableEqualityComparer<global::UniRx.NotificationKind>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.CountChangedStatus>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.CountChangedStatusFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.CountChangedStatus>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.CountChangedStatusEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.CountChangedStatus?>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NullableCountChangedStatusFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.CountChangedStatus?>.Register(new NullableEqualityComparer<global::UniRx.CountChangedStatus>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.LazyTask.TaskStatus>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.LazyTask_TaskStatusFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.LazyTask.TaskStatus>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.LazyTask_TaskStatusEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.LazyTask.TaskStatus?>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NullableLazyTask_TaskStatusFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.LazyTask.TaskStatus?>.Register(new NullableEqualityComparer<global::UniRx.LazyTask.TaskStatus>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.MainThreadDispatcher.CullingMode>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.MainThreadDispatcher_CullingModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.MainThreadDispatcher.CullingMode>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.MainThreadDispatcher_CullingModeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.MainThreadDispatcher.CullingMode?>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NullableMainThreadDispatcher_CullingModeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.MainThreadDispatcher.CullingMode?>.Register(new NullableEqualityComparer<global::UniRx.MainThreadDispatcher.CullingMode>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.FrameCountType>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.FrameCountTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.FrameCountType>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.FrameCountTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.FrameCountType?>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NullableFrameCountTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.FrameCountType?>.Register(new NullableEqualityComparer<global::UniRx.FrameCountType>());
            
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.MainThreadDispatchType>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.MainThreadDispatchTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.MainThreadDispatchType>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.MainThreadDispatchTypeEqualityComparer());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::UniRx.MainThreadDispatchType?>.Register(new ZeroFormatter.DynamicObjectSegments.UniRx.NullableMainThreadDispatchTypeFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Comparers.ZeroFormatterEqualityComparer<global::UniRx.MainThreadDispatchType?>.Register(new NullableEqualityComparer<global::UniRx.MainThreadDispatchType>());
            
            // Objects
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::ClientConfig.Map>.Register(new ZeroFormatter.DynamicObjectSegments.ClientConfig.MapFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            ZeroFormatter.Formatters.Formatter<ZeroFormatter.Formatters.DefaultResolver, global::ClientConfig.MapItem>.Register(new ZeroFormatter.DynamicObjectSegments.ClientConfig.MapItemFormatter<ZeroFormatter.Formatters.DefaultResolver>());
            // Structs
            // Unions
            // Generics
            ZeroFormatter.Formatters.Formatter.RegisterLazyDictionary<ZeroFormatter.Formatters.DefaultResolver, string, byte[]>();
        }
    }
}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.ClientConfig
{
    using global::System;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;

    public class MapFormatter<TTypeResolver> : Formatter<TTypeResolver, global::ClientConfig.Map>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::ClientConfig.Map value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (0 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, global::ZeroFormatter.ILazyDictionary<string, byte[]>>(ref bytes, startOffset, offset, 0, value._internalDictionary);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 0);
            }
        }

        public override global::ClientConfig.Map Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new MapObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class MapObjectSegment<TTypeResolver> : global::ClientConfig.Map, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        global::ZeroFormatter.ILazyDictionary<string, byte[]> __internalDictionary;

        // 0
        public override global::ZeroFormatter.ILazyDictionary<string, byte[]> _internalDictionary
        {
            get
            {
                return __internalDictionary;
            }
            set
            {
                __tracker.Dirty();
                __internalDictionary = value;
            }
        }


        public MapObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 0, __elementSizes);

            __internalDictionary = ObjectSegmentHelper.DeserializeSegment<TTypeResolver, global::ZeroFormatter.ILazyDictionary<string, byte[]>>(originalBytes, 0, __binaryLastIndex, __tracker);
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (0 + 1));

                offset += ObjectSegmentHelper.SerializeSegment<TTypeResolver, global::ZeroFormatter.ILazyDictionary<string, byte[]>>(ref targetBytes, startOffset, offset, 0, __internalDictionary);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 0);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }

    public class MapItemFormatter<TTypeResolver> : Formatter<TTypeResolver, global::ClientConfig.MapItem>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::ClientConfig.MapItem value)
        {
            var segment = value as IZeroFormatterSegment;
            if (segment != null)
            {
                return segment.Serialize(ref bytes, offset);
            }
            else if (value == null)
            {
                BinaryUtil.WriteInt32(ref bytes, offset, -1);
                return 4;
            }
            else
            {
                var startOffset = offset;

                offset += (8 + 4 * (4 + 1));
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 0, value.id);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 1, value.name);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 2, value.width);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, int>(ref bytes, startOffset, offset, 3, value.height);
                offset += ObjectSegmentHelper.SerializeFromFormatter<TTypeResolver, string>(ref bytes, startOffset, offset, 4, value.pathFormat);

                return ObjectSegmentHelper.WriteSize(ref bytes, startOffset, offset, 4);
            }
        }

        public override global::ClientConfig.MapItem Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = BinaryUtil.ReadInt32(ref bytes, offset);
            if (byteSize == -1)
            {
                byteSize = 4;
                return null;
            }
            return new MapItemObjectSegment<TTypeResolver>(tracker, new ArraySegment<byte>(bytes, offset, byteSize));
        }
    }

    public class MapItemObjectSegment<TTypeResolver> : global::ClientConfig.MapItem, IZeroFormatterSegment
        where TTypeResolver : ITypeResolver, new()
    {
        static readonly int[] __elementSizes = new int[]{ 4, 0, 4, 4, 0 };

        readonly ArraySegment<byte> __originalBytes;
        readonly global::ZeroFormatter.DirtyTracker __tracker;
        readonly int __binaryLastIndex;
        readonly byte[] __extraFixedBytes;

        CacheSegment<TTypeResolver, string> _name;
        CacheSegment<TTypeResolver, string> _pathFormat;

        // 0
        public override int id
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 0, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 0, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 1
        public override string name
        {
            get
            {
                return _name.Value;
            }
            set
            {
                _name.Value = value;
            }
        }

        // 2
        public override int width
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 2, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 2, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 3
        public override int height
        {
            get
            {
                return ObjectSegmentHelper.GetFixedProperty<TTypeResolver, int>(__originalBytes, 3, __binaryLastIndex, __extraFixedBytes, __tracker);
            }
            set
            {
                ObjectSegmentHelper.SetFixedProperty<TTypeResolver, int>(__originalBytes, 3, __binaryLastIndex, __extraFixedBytes, value, __tracker);
            }
        }

        // 4
        public override string pathFormat
        {
            get
            {
                return _pathFormat.Value;
            }
            set
            {
                _pathFormat.Value = value;
            }
        }


        public MapItemObjectSegment(global::ZeroFormatter.DirtyTracker dirtyTracker, ArraySegment<byte> originalBytes)
        {
            var __array = originalBytes.Array;

            this.__originalBytes = originalBytes;
            this.__tracker = dirtyTracker = dirtyTracker.CreateChild();
            this.__binaryLastIndex = BinaryUtil.ReadInt32(ref __array, originalBytes.Offset + 4);

            this.__extraFixedBytes = ObjectSegmentHelper.CreateExtraFixedBytes(this.__binaryLastIndex, 4, __elementSizes);

            _name = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 1, __binaryLastIndex, __tracker));
            _pathFormat = new CacheSegment<TTypeResolver, string>(__tracker, ObjectSegmentHelper.GetSegment(originalBytes, 4, __binaryLastIndex, __tracker));
        }

        public bool CanDirectCopy()
        {
            return !__tracker.IsDirty;
        }

        public ArraySegment<byte> GetBufferReference()
        {
            return __originalBytes;
        }

        public int Serialize(ref byte[] targetBytes, int offset)
        {
            if (__extraFixedBytes != null || __tracker.IsDirty)
            {
                var startOffset = offset;
                offset += (8 + 4 * (4 + 1));

                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 0, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 1, ref _name);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 2, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeFixedLength<TTypeResolver, int>(ref targetBytes, startOffset, offset, 3, __binaryLastIndex, __originalBytes, __extraFixedBytes, __tracker);
                offset += ObjectSegmentHelper.SerializeCacheSegment<TTypeResolver, string>(ref targetBytes, startOffset, offset, 4, ref _pathFormat);

                return ObjectSegmentHelper.WriteSize(ref targetBytes, startOffset, offset, 4);
            }
            else
            {
                return ObjectSegmentHelper.DirectCopyAll(__originalBytes, ref targetBytes, offset);
            }
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class Seeker_ModifierPassFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Seeker.ModifierPass>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Seeker.ModifierPass value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Seeker.ModifierPass Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Seeker.ModifierPass)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableSeeker_ModifierPassFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Seeker.ModifierPass?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Seeker.ModifierPass? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Seeker.ModifierPass? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Seeker.ModifierPass)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class Seeker_ModifierPassEqualityComparer : IEqualityComparer<global::Seeker.ModifierPass>
    {
        public bool Equals(global::Seeker.ModifierPass x, global::Seeker.ModifierPass y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Seeker.ModifierPass x)
        {
            return (int)x;
        }
    }



    public class AstarPath_AstarDistributionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AstarPath.AstarDistribution>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AstarPath.AstarDistribution value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::AstarPath.AstarDistribution Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::AstarPath.AstarDistribution)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableAstarPath_AstarDistributionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AstarPath.AstarDistribution?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AstarPath.AstarDistribution? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::AstarPath.AstarDistribution? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::AstarPath.AstarDistribution)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class AstarPath_AstarDistributionEqualityComparer : IEqualityComparer<global::AstarPath.AstarDistribution>
    {
        public bool Equals(global::AstarPath.AstarDistribution x, global::AstarPath.AstarDistribution y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::AstarPath.AstarDistribution x)
        {
            return (int)x;
        }
    }



    public class BlockManager_BlockModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::BlockManager.BlockMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::BlockManager.BlockMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::BlockManager.BlockMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::BlockManager.BlockMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableBlockManager_BlockModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::BlockManager.BlockMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::BlockManager.BlockMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::BlockManager.BlockMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::BlockManager.BlockMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class BlockManager_BlockModeEqualityComparer : IEqualityComparer<global::BlockManager.BlockMode>
    {
        public bool Equals(global::BlockManager.BlockMode x, global::BlockManager.BlockMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::BlockManager.BlockMode x)
        {
            return (int)x;
        }
    }



    public class UIButtonColor_StateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIButtonColor.State>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIButtonColor.State value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIButtonColor.State Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIButtonColor.State)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIButtonColor_StateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIButtonColor.State?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIButtonColor.State? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIButtonColor.State? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIButtonColor.State)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIButtonColor_StateEqualityComparer : IEqualityComparer<global::UIButtonColor.State>
    {
        public bool Equals(global::UIButtonColor.State x, global::UIButtonColor.State y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIButtonColor.State x)
        {
            return (int)x;
        }
    }



    public class UIButtonMessage_TriggerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIButtonMessage.Trigger>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIButtonMessage.Trigger value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIButtonMessage.Trigger Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIButtonMessage.Trigger)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIButtonMessage_TriggerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIButtonMessage.Trigger?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIButtonMessage.Trigger? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIButtonMessage.Trigger? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIButtonMessage.Trigger)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIButtonMessage_TriggerEqualityComparer : IEqualityComparer<global::UIButtonMessage.Trigger>
    {
        public bool Equals(global::UIButtonMessage.Trigger x, global::UIButtonMessage.Trigger y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIButtonMessage.Trigger x)
        {
            return (int)x;
        }
    }



    public class UIDragDropItem_RestrictionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDragDropItem.Restriction>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDragDropItem.Restriction value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIDragDropItem.Restriction Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIDragDropItem.Restriction)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIDragDropItem_RestrictionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDragDropItem.Restriction?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDragDropItem.Restriction? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIDragDropItem.Restriction? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIDragDropItem.Restriction)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIDragDropItem_RestrictionEqualityComparer : IEqualityComparer<global::UIDragDropItem.Restriction>
    {
        public bool Equals(global::UIDragDropItem.Restriction x, global::UIDragDropItem.Restriction y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIDragDropItem.Restriction x)
        {
            return (int)x;
        }
    }



    public class UIDragObject_DragEffectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDragObject.DragEffect>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDragObject.DragEffect value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIDragObject.DragEffect Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIDragObject.DragEffect)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIDragObject_DragEffectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDragObject.DragEffect?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDragObject.DragEffect? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIDragObject.DragEffect? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIDragObject.DragEffect)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIDragObject_DragEffectEqualityComparer : IEqualityComparer<global::UIDragObject.DragEffect>
    {
        public bool Equals(global::UIDragObject.DragEffect x, global::UIDragObject.DragEffect y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIDragObject.DragEffect x)
        {
            return (int)x;
        }
    }



    public class UIGrid_ArrangementFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIGrid.Arrangement>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIGrid.Arrangement value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIGrid.Arrangement Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIGrid.Arrangement)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIGrid_ArrangementFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIGrid.Arrangement?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIGrid.Arrangement? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIGrid.Arrangement? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIGrid.Arrangement)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIGrid_ArrangementEqualityComparer : IEqualityComparer<global::UIGrid.Arrangement>
    {
        public bool Equals(global::UIGrid.Arrangement x, global::UIGrid.Arrangement y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIGrid.Arrangement x)
        {
            return (int)x;
        }
    }



    public class UIGrid_SortingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIGrid.Sorting>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIGrid.Sorting value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIGrid.Sorting Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIGrid.Sorting)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIGrid_SortingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIGrid.Sorting?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIGrid.Sorting? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIGrid.Sorting? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIGrid.Sorting)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIGrid_SortingEqualityComparer : IEqualityComparer<global::UIGrid.Sorting>
    {
        public bool Equals(global::UIGrid.Sorting x, global::UIGrid.Sorting y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIGrid.Sorting x)
        {
            return (int)x;
        }
    }



    public class UIKeyBinding_ActionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIKeyBinding.Action>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIKeyBinding.Action value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIKeyBinding.Action Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIKeyBinding.Action)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIKeyBinding_ActionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIKeyBinding.Action?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIKeyBinding.Action? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIKeyBinding.Action? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIKeyBinding.Action)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIKeyBinding_ActionEqualityComparer : IEqualityComparer<global::UIKeyBinding.Action>
    {
        public bool Equals(global::UIKeyBinding.Action x, global::UIKeyBinding.Action y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIKeyBinding.Action x)
        {
            return (int)x;
        }
    }



    public class UIKeyBinding_ModifierFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIKeyBinding.Modifier>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIKeyBinding.Modifier value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIKeyBinding.Modifier Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIKeyBinding.Modifier)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIKeyBinding_ModifierFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIKeyBinding.Modifier?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIKeyBinding.Modifier? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIKeyBinding.Modifier? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIKeyBinding.Modifier)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIKeyBinding_ModifierEqualityComparer : IEqualityComparer<global::UIKeyBinding.Modifier>
    {
        public bool Equals(global::UIKeyBinding.Modifier x, global::UIKeyBinding.Modifier y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIKeyBinding.Modifier x)
        {
            return (int)x;
        }
    }



    public class UIKeyNavigation_ConstraintFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIKeyNavigation.Constraint>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIKeyNavigation.Constraint value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIKeyNavigation.Constraint Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIKeyNavigation.Constraint)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIKeyNavigation_ConstraintFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIKeyNavigation.Constraint?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIKeyNavigation.Constraint? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIKeyNavigation.Constraint? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIKeyNavigation.Constraint)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIKeyNavigation_ConstraintEqualityComparer : IEqualityComparer<global::UIKeyNavigation.Constraint>
    {
        public bool Equals(global::UIKeyNavigation.Constraint x, global::UIKeyNavigation.Constraint y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIKeyNavigation.Constraint x)
        {
            return (int)x;
        }
    }



    public class UIPlaySound_TriggerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPlaySound.Trigger>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPlaySound.Trigger value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIPlaySound.Trigger Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIPlaySound.Trigger)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIPlaySound_TriggerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPlaySound.Trigger?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPlaySound.Trigger? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIPlaySound.Trigger? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIPlaySound.Trigger)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIPlaySound_TriggerEqualityComparer : IEqualityComparer<global::UIPlaySound.Trigger>
    {
        public bool Equals(global::UIPlaySound.Trigger x, global::UIPlaySound.Trigger y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIPlaySound.Trigger x)
        {
            return (int)x;
        }
    }



    public class UIPopupList_PositionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPopupList.Position>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPopupList.Position value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIPopupList.Position Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIPopupList.Position)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIPopupList_PositionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPopupList.Position?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPopupList.Position? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIPopupList.Position? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIPopupList.Position)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIPopupList_PositionEqualityComparer : IEqualityComparer<global::UIPopupList.Position>
    {
        public bool Equals(global::UIPopupList.Position x, global::UIPopupList.Position y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIPopupList.Position x)
        {
            return (int)x;
        }
    }



    public class UIPopupList_SelectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPopupList.Selection>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPopupList.Selection value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIPopupList.Selection Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIPopupList.Selection)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIPopupList_SelectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPopupList.Selection?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPopupList.Selection? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIPopupList.Selection? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIPopupList.Selection)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIPopupList_SelectionEqualityComparer : IEqualityComparer<global::UIPopupList.Selection>
    {
        public bool Equals(global::UIPopupList.Selection x, global::UIPopupList.Selection y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIPopupList.Selection x)
        {
            return (int)x;
        }
    }



    public class UIPopupList_OpenOnFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPopupList.OpenOn>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPopupList.OpenOn value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIPopupList.OpenOn Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIPopupList.OpenOn)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIPopupList_OpenOnFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPopupList.OpenOn?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPopupList.OpenOn? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIPopupList.OpenOn? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIPopupList.OpenOn)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIPopupList_OpenOnEqualityComparer : IEqualityComparer<global::UIPopupList.OpenOn>
    {
        public bool Equals(global::UIPopupList.OpenOn x, global::UIPopupList.OpenOn y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIPopupList.OpenOn x)
        {
            return (int)x;
        }
    }



    public class UIProgressBar_FillDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIProgressBar.FillDirection>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIProgressBar.FillDirection value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIProgressBar.FillDirection Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIProgressBar.FillDirection)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIProgressBar_FillDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIProgressBar.FillDirection?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIProgressBar.FillDirection? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIProgressBar.FillDirection? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIProgressBar.FillDirection)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIProgressBar_FillDirectionEqualityComparer : IEqualityComparer<global::UIProgressBar.FillDirection>
    {
        public bool Equals(global::UIProgressBar.FillDirection x, global::UIProgressBar.FillDirection y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIProgressBar.FillDirection x)
        {
            return (int)x;
        }
    }



    public class UIScrollView_MovementFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIScrollView.Movement>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIScrollView.Movement value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIScrollView.Movement Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIScrollView.Movement)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIScrollView_MovementFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIScrollView.Movement?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIScrollView.Movement? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIScrollView.Movement? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIScrollView.Movement)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIScrollView_MovementEqualityComparer : IEqualityComparer<global::UIScrollView.Movement>
    {
        public bool Equals(global::UIScrollView.Movement x, global::UIScrollView.Movement y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIScrollView.Movement x)
        {
            return (int)x;
        }
    }



    public class UIScrollView_DragEffectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIScrollView.DragEffect>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIScrollView.DragEffect value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIScrollView.DragEffect Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIScrollView.DragEffect)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIScrollView_DragEffectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIScrollView.DragEffect?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIScrollView.DragEffect? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIScrollView.DragEffect? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIScrollView.DragEffect)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIScrollView_DragEffectEqualityComparer : IEqualityComparer<global::UIScrollView.DragEffect>
    {
        public bool Equals(global::UIScrollView.DragEffect x, global::UIScrollView.DragEffect y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIScrollView.DragEffect x)
        {
            return (int)x;
        }
    }



    public class UIScrollView_ShowConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIScrollView.ShowCondition>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIScrollView.ShowCondition value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIScrollView.ShowCondition Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIScrollView.ShowCondition)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIScrollView_ShowConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIScrollView.ShowCondition?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIScrollView.ShowCondition? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIScrollView.ShowCondition? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIScrollView.ShowCondition)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIScrollView_ShowConditionEqualityComparer : IEqualityComparer<global::UIScrollView.ShowCondition>
    {
        public bool Equals(global::UIScrollView.ShowCondition x, global::UIScrollView.ShowCondition y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIScrollView.ShowCondition x)
        {
            return (int)x;
        }
    }



    public class UITable_DirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITable.Direction>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITable.Direction value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UITable.Direction Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UITable.Direction)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUITable_DirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITable.Direction?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITable.Direction? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UITable.Direction? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UITable.Direction)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UITable_DirectionEqualityComparer : IEqualityComparer<global::UITable.Direction>
    {
        public bool Equals(global::UITable.Direction x, global::UITable.Direction y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UITable.Direction x)
        {
            return (int)x;
        }
    }



    public class UITable_SortingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITable.Sorting>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITable.Sorting value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UITable.Sorting Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UITable.Sorting)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUITable_SortingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITable.Sorting?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITable.Sorting? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UITable.Sorting? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UITable.Sorting)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UITable_SortingEqualityComparer : IEqualityComparer<global::UITable.Sorting>
    {
        public bool Equals(global::UITable.Sorting x, global::UITable.Sorting y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UITable.Sorting x)
        {
            return (int)x;
        }
    }



    public class NGUIText_AlignmentFormatter<TTypeResolver> : Formatter<TTypeResolver, global::NGUIText.Alignment>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::NGUIText.Alignment value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::NGUIText.Alignment Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::NGUIText.Alignment)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableNGUIText_AlignmentFormatter<TTypeResolver> : Formatter<TTypeResolver, global::NGUIText.Alignment?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::NGUIText.Alignment? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::NGUIText.Alignment? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::NGUIText.Alignment)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class NGUIText_AlignmentEqualityComparer : IEqualityComparer<global::NGUIText.Alignment>
    {
        public bool Equals(global::NGUIText.Alignment x, global::NGUIText.Alignment y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::NGUIText.Alignment x)
        {
            return (int)x;
        }
    }



    public class NGUIText_SymbolStyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::NGUIText.SymbolStyle>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::NGUIText.SymbolStyle value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::NGUIText.SymbolStyle Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::NGUIText.SymbolStyle)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableNGUIText_SymbolStyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::NGUIText.SymbolStyle?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::NGUIText.SymbolStyle? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::NGUIText.SymbolStyle? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::NGUIText.SymbolStyle)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class NGUIText_SymbolStyleEqualityComparer : IEqualityComparer<global::NGUIText.SymbolStyle>
    {
        public bool Equals(global::NGUIText.SymbolStyle x, global::NGUIText.SymbolStyle y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::NGUIText.SymbolStyle x)
        {
            return (int)x;
        }
    }



    public class PropertyBinding_UpdateConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::PropertyBinding.UpdateCondition>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::PropertyBinding.UpdateCondition value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::PropertyBinding.UpdateCondition Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::PropertyBinding.UpdateCondition)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullablePropertyBinding_UpdateConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::PropertyBinding.UpdateCondition?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::PropertyBinding.UpdateCondition? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::PropertyBinding.UpdateCondition? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::PropertyBinding.UpdateCondition)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class PropertyBinding_UpdateConditionEqualityComparer : IEqualityComparer<global::PropertyBinding.UpdateCondition>
    {
        public bool Equals(global::PropertyBinding.UpdateCondition x, global::PropertyBinding.UpdateCondition y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::PropertyBinding.UpdateCondition x)
        {
            return (int)x;
        }
    }



    public class PropertyBinding_DirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::PropertyBinding.Direction>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::PropertyBinding.Direction value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::PropertyBinding.Direction Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::PropertyBinding.Direction)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullablePropertyBinding_DirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::PropertyBinding.Direction?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::PropertyBinding.Direction? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::PropertyBinding.Direction? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::PropertyBinding.Direction)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class PropertyBinding_DirectionEqualityComparer : IEqualityComparer<global::PropertyBinding.Direction>
    {
        public bool Equals(global::PropertyBinding.Direction x, global::PropertyBinding.Direction y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::PropertyBinding.Direction x)
        {
            return (int)x;
        }
    }



    public class UIBasicSprite_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.Type>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.Type value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIBasicSprite.Type Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIBasicSprite.Type)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIBasicSprite_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.Type?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.Type? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIBasicSprite.Type? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIBasicSprite.Type)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIBasicSprite_TypeEqualityComparer : IEqualityComparer<global::UIBasicSprite.Type>
    {
        public bool Equals(global::UIBasicSprite.Type x, global::UIBasicSprite.Type y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIBasicSprite.Type x)
        {
            return (int)x;
        }
    }



    public class UIBasicSprite_FillDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.FillDirection>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.FillDirection value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIBasicSprite.FillDirection Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIBasicSprite.FillDirection)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIBasicSprite_FillDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.FillDirection?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.FillDirection? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIBasicSprite.FillDirection? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIBasicSprite.FillDirection)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIBasicSprite_FillDirectionEqualityComparer : IEqualityComparer<global::UIBasicSprite.FillDirection>
    {
        public bool Equals(global::UIBasicSprite.FillDirection x, global::UIBasicSprite.FillDirection y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIBasicSprite.FillDirection x)
        {
            return (int)x;
        }
    }



    public class UIBasicSprite_AdvancedTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.AdvancedType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.AdvancedType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIBasicSprite.AdvancedType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIBasicSprite.AdvancedType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIBasicSprite_AdvancedTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.AdvancedType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.AdvancedType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIBasicSprite.AdvancedType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIBasicSprite.AdvancedType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIBasicSprite_AdvancedTypeEqualityComparer : IEqualityComparer<global::UIBasicSprite.AdvancedType>
    {
        public bool Equals(global::UIBasicSprite.AdvancedType x, global::UIBasicSprite.AdvancedType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIBasicSprite.AdvancedType x)
        {
            return (int)x;
        }
    }



    public class UIBasicSprite_FlipFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.Flip>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.Flip value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIBasicSprite.Flip Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIBasicSprite.Flip)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIBasicSprite_FlipFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIBasicSprite.Flip?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIBasicSprite.Flip? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIBasicSprite.Flip? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIBasicSprite.Flip)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIBasicSprite_FlipEqualityComparer : IEqualityComparer<global::UIBasicSprite.Flip>
    {
        public bool Equals(global::UIBasicSprite.Flip x, global::UIBasicSprite.Flip y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIBasicSprite.Flip x)
        {
            return (int)x;
        }
    }



    public class UIDrawCall_ClippingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDrawCall.Clipping>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDrawCall.Clipping value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIDrawCall.Clipping Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIDrawCall.Clipping)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIDrawCall_ClippingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDrawCall.Clipping?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDrawCall.Clipping? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIDrawCall.Clipping? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIDrawCall.Clipping)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIDrawCall_ClippingEqualityComparer : IEqualityComparer<global::UIDrawCall.Clipping>
    {
        public bool Equals(global::UIDrawCall.Clipping x, global::UIDrawCall.Clipping y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIDrawCall.Clipping x)
        {
            return (int)x;
        }
    }



    public class UIDrawCall_ShadowModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDrawCall.ShadowMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDrawCall.ShadowMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIDrawCall.ShadowMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIDrawCall.ShadowMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIDrawCall_ShadowModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIDrawCall.ShadowMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIDrawCall.ShadowMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIDrawCall.ShadowMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIDrawCall.ShadowMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIDrawCall_ShadowModeEqualityComparer : IEqualityComparer<global::UIDrawCall.ShadowMode>
    {
        public bool Equals(global::UIDrawCall.ShadowMode x, global::UIDrawCall.ShadowMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIDrawCall.ShadowMode x)
        {
            return (int)x;
        }
    }



    public class UIRect_AnchorUpdateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIRect.AnchorUpdate>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIRect.AnchorUpdate value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIRect.AnchorUpdate Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIRect.AnchorUpdate)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIRect_AnchorUpdateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIRect.AnchorUpdate?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIRect.AnchorUpdate? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIRect.AnchorUpdate? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIRect.AnchorUpdate)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIRect_AnchorUpdateEqualityComparer : IEqualityComparer<global::UIRect.AnchorUpdate>
    {
        public bool Equals(global::UIRect.AnchorUpdate x, global::UIRect.AnchorUpdate y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIRect.AnchorUpdate x)
        {
            return (int)x;
        }
    }



    public class UIWidget_PivotFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIWidget.Pivot>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIWidget.Pivot value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIWidget.Pivot Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIWidget.Pivot)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIWidget_PivotFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIWidget.Pivot?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIWidget.Pivot? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIWidget.Pivot? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIWidget.Pivot)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIWidget_PivotEqualityComparer : IEqualityComparer<global::UIWidget.Pivot>
    {
        public bool Equals(global::UIWidget.Pivot x, global::UIWidget.Pivot y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIWidget.Pivot x)
        {
            return (int)x;
        }
    }



    public class UIWidget_AspectRatioSourceFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIWidget.AspectRatioSource>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIWidget.AspectRatioSource value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIWidget.AspectRatioSource Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIWidget.AspectRatioSource)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIWidget_AspectRatioSourceFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIWidget.AspectRatioSource?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIWidget.AspectRatioSource? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIWidget.AspectRatioSource? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIWidget.AspectRatioSource)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIWidget_AspectRatioSourceEqualityComparer : IEqualityComparer<global::UIWidget.AspectRatioSource>
    {
        public bool Equals(global::UIWidget.AspectRatioSource x, global::UIWidget.AspectRatioSource y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIWidget.AspectRatioSource x)
        {
            return (int)x;
        }
    }



    public class TweenLetters_AnimationLetterOrderFormatter<TTypeResolver> : Formatter<TTypeResolver, global::TweenLetters.AnimationLetterOrder>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::TweenLetters.AnimationLetterOrder value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::TweenLetters.AnimationLetterOrder Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::TweenLetters.AnimationLetterOrder)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableTweenLetters_AnimationLetterOrderFormatter<TTypeResolver> : Formatter<TTypeResolver, global::TweenLetters.AnimationLetterOrder?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::TweenLetters.AnimationLetterOrder? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::TweenLetters.AnimationLetterOrder? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::TweenLetters.AnimationLetterOrder)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class TweenLetters_AnimationLetterOrderEqualityComparer : IEqualityComparer<global::TweenLetters.AnimationLetterOrder>
    {
        public bool Equals(global::TweenLetters.AnimationLetterOrder x, global::TweenLetters.AnimationLetterOrder y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::TweenLetters.AnimationLetterOrder x)
        {
            return (int)x;
        }
    }



    public class UITweener_MethodFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITweener.Method>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITweener.Method value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UITweener.Method Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UITweener.Method)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUITweener_MethodFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITweener.Method?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITweener.Method? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UITweener.Method? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UITweener.Method)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UITweener_MethodEqualityComparer : IEqualityComparer<global::UITweener.Method>
    {
        public bool Equals(global::UITweener.Method x, global::UITweener.Method y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UITweener.Method x)
        {
            return (int)x;
        }
    }



    public class UITweener_StyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITweener.Style>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITweener.Style value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UITweener.Style Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UITweener.Style)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUITweener_StyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITweener.Style?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITweener.Style? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UITweener.Style? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UITweener.Style)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UITweener_StyleEqualityComparer : IEqualityComparer<global::UITweener.Style>
    {
        public bool Equals(global::UITweener.Style x, global::UITweener.Style y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UITweener.Style x)
        {
            return (int)x;
        }
    }



    public class UIAnchor_SideFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIAnchor.Side>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIAnchor.Side value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIAnchor.Side Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIAnchor.Side)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIAnchor_SideFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIAnchor.Side?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIAnchor.Side? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIAnchor.Side? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIAnchor.Side)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIAnchor_SideEqualityComparer : IEqualityComparer<global::UIAnchor.Side>
    {
        public bool Equals(global::UIAnchor.Side x, global::UIAnchor.Side y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIAnchor.Side x)
        {
            return (int)x;
        }
    }



    public class UICamera_ControlSchemeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.ControlScheme>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.ControlScheme value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UICamera.ControlScheme Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UICamera.ControlScheme)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUICamera_ControlSchemeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.ControlScheme?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.ControlScheme? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UICamera.ControlScheme? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UICamera.ControlScheme)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UICamera_ControlSchemeEqualityComparer : IEqualityComparer<global::UICamera.ControlScheme>
    {
        public bool Equals(global::UICamera.ControlScheme x, global::UICamera.ControlScheme y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UICamera.ControlScheme x)
        {
            return (int)x;
        }
    }



    public class UICamera_ClickNotificationFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.ClickNotification>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.ClickNotification value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UICamera.ClickNotification Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UICamera.ClickNotification)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUICamera_ClickNotificationFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.ClickNotification?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.ClickNotification? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UICamera.ClickNotification? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UICamera.ClickNotification)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UICamera_ClickNotificationEqualityComparer : IEqualityComparer<global::UICamera.ClickNotification>
    {
        public bool Equals(global::UICamera.ClickNotification x, global::UICamera.ClickNotification y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UICamera.ClickNotification x)
        {
            return (int)x;
        }
    }



    public class UICamera_EventTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.EventType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.EventType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UICamera.EventType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UICamera.EventType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUICamera_EventTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.EventType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.EventType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UICamera.EventType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UICamera.EventType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UICamera_EventTypeEqualityComparer : IEqualityComparer<global::UICamera.EventType>
    {
        public bool Equals(global::UICamera.EventType x, global::UICamera.EventType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UICamera.EventType x)
        {
            return (int)x;
        }
    }



    public class UICamera_ProcessEventsInFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.ProcessEventsIn>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.ProcessEventsIn value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UICamera.ProcessEventsIn Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UICamera.ProcessEventsIn)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUICamera_ProcessEventsInFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UICamera.ProcessEventsIn?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UICamera.ProcessEventsIn? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UICamera.ProcessEventsIn? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UICamera.ProcessEventsIn)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UICamera_ProcessEventsInEqualityComparer : IEqualityComparer<global::UICamera.ProcessEventsIn>
    {
        public bool Equals(global::UICamera.ProcessEventsIn x, global::UICamera.ProcessEventsIn y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UICamera.ProcessEventsIn x)
        {
            return (int)x;
        }
    }



    public class UIInput_InputTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.InputType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.InputType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIInput.InputType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIInput.InputType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIInput_InputTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.InputType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.InputType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIInput.InputType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIInput.InputType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIInput_InputTypeEqualityComparer : IEqualityComparer<global::UIInput.InputType>
    {
        public bool Equals(global::UIInput.InputType x, global::UIInput.InputType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIInput.InputType x)
        {
            return (int)x;
        }
    }



    public class UIInput_ValidationFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.Validation>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.Validation value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIInput.Validation Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIInput.Validation)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIInput_ValidationFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.Validation?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.Validation? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIInput.Validation? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIInput.Validation)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIInput_ValidationEqualityComparer : IEqualityComparer<global::UIInput.Validation>
    {
        public bool Equals(global::UIInput.Validation x, global::UIInput.Validation y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIInput.Validation x)
        {
            return (int)x;
        }
    }



    public class UIInput_KeyboardTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.KeyboardType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.KeyboardType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIInput.KeyboardType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIInput.KeyboardType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIInput_KeyboardTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.KeyboardType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.KeyboardType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIInput.KeyboardType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIInput.KeyboardType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIInput_KeyboardTypeEqualityComparer : IEqualityComparer<global::UIInput.KeyboardType>
    {
        public bool Equals(global::UIInput.KeyboardType x, global::UIInput.KeyboardType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIInput.KeyboardType x)
        {
            return (int)x;
        }
    }



    public class UIInput_OnReturnKeyFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.OnReturnKey>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.OnReturnKey value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIInput.OnReturnKey Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIInput.OnReturnKey)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIInput_OnReturnKeyFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIInput.OnReturnKey?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIInput.OnReturnKey? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIInput.OnReturnKey? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIInput.OnReturnKey)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIInput_OnReturnKeyEqualityComparer : IEqualityComparer<global::UIInput.OnReturnKey>
    {
        public bool Equals(global::UIInput.OnReturnKey x, global::UIInput.OnReturnKey y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIInput.OnReturnKey x)
        {
            return (int)x;
        }
    }



    public class UILabel_EffectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Effect>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Effect value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UILabel.Effect Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UILabel.Effect)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUILabel_EffectFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Effect?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Effect? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UILabel.Effect? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UILabel.Effect)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UILabel_EffectEqualityComparer : IEqualityComparer<global::UILabel.Effect>
    {
        public bool Equals(global::UILabel.Effect x, global::UILabel.Effect y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UILabel.Effect x)
        {
            return (int)x;
        }
    }



    public class UILabel_OverflowFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Overflow>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Overflow value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UILabel.Overflow Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UILabel.Overflow)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUILabel_OverflowFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Overflow?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Overflow? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UILabel.Overflow? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UILabel.Overflow)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UILabel_OverflowEqualityComparer : IEqualityComparer<global::UILabel.Overflow>
    {
        public bool Equals(global::UILabel.Overflow x, global::UILabel.Overflow y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UILabel.Overflow x)
        {
            return (int)x;
        }
    }



    public class UILabel_CrispnessFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Crispness>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Crispness value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UILabel.Crispness Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UILabel.Crispness)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUILabel_CrispnessFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Crispness?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Crispness? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UILabel.Crispness? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UILabel.Crispness)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UILabel_CrispnessEqualityComparer : IEqualityComparer<global::UILabel.Crispness>
    {
        public bool Equals(global::UILabel.Crispness x, global::UILabel.Crispness y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UILabel.Crispness x)
        {
            return (int)x;
        }
    }



    public class UILabel_ModifierFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Modifier>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Modifier value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UILabel.Modifier Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UILabel.Modifier)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUILabel_ModifierFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UILabel.Modifier?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UILabel.Modifier? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UILabel.Modifier? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UILabel.Modifier)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UILabel_ModifierEqualityComparer : IEqualityComparer<global::UILabel.Modifier>
    {
        public bool Equals(global::UILabel.Modifier x, global::UILabel.Modifier y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UILabel.Modifier x)
        {
            return (int)x;
        }
    }



    public class UIPanel_RenderQueueFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPanel.RenderQueue>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPanel.RenderQueue value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIPanel.RenderQueue Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIPanel.RenderQueue)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIPanel_RenderQueueFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIPanel.RenderQueue?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIPanel.RenderQueue? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIPanel.RenderQueue? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIPanel.RenderQueue)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIPanel_RenderQueueEqualityComparer : IEqualityComparer<global::UIPanel.RenderQueue>
    {
        public bool Equals(global::UIPanel.RenderQueue x, global::UIPanel.RenderQueue y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIPanel.RenderQueue x)
        {
            return (int)x;
        }
    }



    public class UIRoot_ScalingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIRoot.Scaling>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIRoot.Scaling value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIRoot.Scaling Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIRoot.Scaling)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIRoot_ScalingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIRoot.Scaling?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIRoot.Scaling? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIRoot.Scaling? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIRoot.Scaling)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIRoot_ScalingEqualityComparer : IEqualityComparer<global::UIRoot.Scaling>
    {
        public bool Equals(global::UIRoot.Scaling x, global::UIRoot.Scaling y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIRoot.Scaling x)
        {
            return (int)x;
        }
    }



    public class UIRoot_ConstraintFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIRoot.Constraint>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIRoot.Constraint value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIRoot.Constraint Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIRoot.Constraint)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIRoot_ConstraintFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIRoot.Constraint?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIRoot.Constraint? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIRoot.Constraint? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIRoot.Constraint)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIRoot_ConstraintEqualityComparer : IEqualityComparer<global::UIRoot.Constraint>
    {
        public bool Equals(global::UIRoot.Constraint x, global::UIRoot.Constraint y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIRoot.Constraint x)
        {
            return (int)x;
        }
    }



    public class UIStretch_StyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIStretch.Style>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIStretch.Style value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UIStretch.Style Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UIStretch.Style)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUIStretch_StyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UIStretch.Style?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UIStretch.Style? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UIStretch.Style? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UIStretch.Style)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UIStretch_StyleEqualityComparer : IEqualityComparer<global::UIStretch.Style>
    {
        public bool Equals(global::UIStretch.Style x, global::UIStretch.Style y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UIStretch.Style x)
        {
            return (int)x;
        }
    }



    public class UITextList_StyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITextList.Style>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITextList.Style value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UITextList.Style Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UITextList.Style)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableUITextList_StyleFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UITextList.Style?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UITextList.Style? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UITextList.Style? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UITextList.Style)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class UITextList_StyleEqualityComparer : IEqualityComparer<global::UITextList.Style>
    {
        public bool Equals(global::UITextList.Style x, global::UITextList.Style y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UITextList.Style x)
        {
            return (int)x;
        }
    }



    public class tk2dCameraSettings_ProjectionTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraSettings.ProjectionType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraSettings.ProjectionType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dCameraSettings.ProjectionType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dCameraSettings.ProjectionType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dCameraSettings_ProjectionTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraSettings.ProjectionType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraSettings.ProjectionType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dCameraSettings.ProjectionType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dCameraSettings.ProjectionType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dCameraSettings_ProjectionTypeEqualityComparer : IEqualityComparer<global::tk2dCameraSettings.ProjectionType>
    {
        public bool Equals(global::tk2dCameraSettings.ProjectionType x, global::tk2dCameraSettings.ProjectionType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dCameraSettings.ProjectionType x)
        {
            return (int)x;
        }
    }



    public class tk2dCameraSettings_OrthographicTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraSettings.OrthographicType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraSettings.OrthographicType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dCameraSettings.OrthographicType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dCameraSettings.OrthographicType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dCameraSettings_OrthographicTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraSettings.OrthographicType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraSettings.OrthographicType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dCameraSettings.OrthographicType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dCameraSettings.OrthographicType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dCameraSettings_OrthographicTypeEqualityComparer : IEqualityComparer<global::tk2dCameraSettings.OrthographicType>
    {
        public bool Equals(global::tk2dCameraSettings.OrthographicType x, global::tk2dCameraSettings.OrthographicType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dCameraSettings.OrthographicType x)
        {
            return (int)x;
        }
    }



    public class tk2dCameraSettings_OrthographicOriginFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraSettings.OrthographicOrigin>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraSettings.OrthographicOrigin value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dCameraSettings.OrthographicOrigin Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dCameraSettings.OrthographicOrigin)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dCameraSettings_OrthographicOriginFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraSettings.OrthographicOrigin?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraSettings.OrthographicOrigin? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dCameraSettings.OrthographicOrigin? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dCameraSettings.OrthographicOrigin)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dCameraSettings_OrthographicOriginEqualityComparer : IEqualityComparer<global::tk2dCameraSettings.OrthographicOrigin>
    {
        public bool Equals(global::tk2dCameraSettings.OrthographicOrigin x, global::tk2dCameraSettings.OrthographicOrigin y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dCameraSettings.OrthographicOrigin x)
        {
            return (int)x;
        }
    }



    public class tk2dCameraResolutionOverride_MatchByTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraResolutionOverride.MatchByType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraResolutionOverride.MatchByType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dCameraResolutionOverride.MatchByType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dCameraResolutionOverride.MatchByType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dCameraResolutionOverride_MatchByTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraResolutionOverride.MatchByType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraResolutionOverride.MatchByType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dCameraResolutionOverride.MatchByType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dCameraResolutionOverride.MatchByType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dCameraResolutionOverride_MatchByTypeEqualityComparer : IEqualityComparer<global::tk2dCameraResolutionOverride.MatchByType>
    {
        public bool Equals(global::tk2dCameraResolutionOverride.MatchByType x, global::tk2dCameraResolutionOverride.MatchByType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dCameraResolutionOverride.MatchByType x)
        {
            return (int)x;
        }
    }



    public class tk2dCameraResolutionOverride_AutoScaleModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraResolutionOverride.AutoScaleMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraResolutionOverride.AutoScaleMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dCameraResolutionOverride.AutoScaleMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dCameraResolutionOverride.AutoScaleMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dCameraResolutionOverride_AutoScaleModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraResolutionOverride.AutoScaleMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraResolutionOverride.AutoScaleMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dCameraResolutionOverride.AutoScaleMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dCameraResolutionOverride.AutoScaleMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dCameraResolutionOverride_AutoScaleModeEqualityComparer : IEqualityComparer<global::tk2dCameraResolutionOverride.AutoScaleMode>
    {
        public bool Equals(global::tk2dCameraResolutionOverride.AutoScaleMode x, global::tk2dCameraResolutionOverride.AutoScaleMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dCameraResolutionOverride.AutoScaleMode x)
        {
            return (int)x;
        }
    }



    public class tk2dCameraResolutionOverride_FitModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraResolutionOverride.FitMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraResolutionOverride.FitMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dCameraResolutionOverride.FitMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dCameraResolutionOverride.FitMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dCameraResolutionOverride_FitModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dCameraResolutionOverride.FitMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dCameraResolutionOverride.FitMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dCameraResolutionOverride.FitMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dCameraResolutionOverride.FitMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dCameraResolutionOverride_FitModeEqualityComparer : IEqualityComparer<global::tk2dCameraResolutionOverride.FitMode>
    {
        public bool Equals(global::tk2dCameraResolutionOverride.FitMode x, global::tk2dCameraResolutionOverride.FitMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dCameraResolutionOverride.FitMode x)
        {
            return (int)x;
        }
    }



    public class tk2dBaseSprite_AnchorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dBaseSprite.Anchor>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dBaseSprite.Anchor value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dBaseSprite.Anchor Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dBaseSprite.Anchor)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dBaseSprite_AnchorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dBaseSprite.Anchor?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dBaseSprite.Anchor? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dBaseSprite.Anchor? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dBaseSprite.Anchor)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dBaseSprite_AnchorEqualityComparer : IEqualityComparer<global::tk2dBaseSprite.Anchor>
    {
        public bool Equals(global::tk2dBaseSprite.Anchor x, global::tk2dBaseSprite.Anchor y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dBaseSprite.Anchor x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteAnimationClip_WrapModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteAnimationClip.WrapMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteAnimationClip.WrapMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteAnimationClip.WrapMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteAnimationClip.WrapMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteAnimationClip_WrapModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteAnimationClip.WrapMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteAnimationClip.WrapMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteAnimationClip.WrapMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteAnimationClip.WrapMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteAnimationClip_WrapModeEqualityComparer : IEqualityComparer<global::tk2dSpriteAnimationClip.WrapMode>
    {
        public bool Equals(global::tk2dSpriteAnimationClip.WrapMode x, global::tk2dSpriteAnimationClip.WrapMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteAnimationClip.WrapMode x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_AnchorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.Anchor>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.Anchor value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.Anchor Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.Anchor)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_AnchorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.Anchor?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.Anchor? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.Anchor? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.Anchor)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_AnchorEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.Anchor>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.Anchor x, global::tk2dSpriteCollectionDefinition.Anchor y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.Anchor x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_PadFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.Pad>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.Pad value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.Pad Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.Pad)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_PadFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.Pad?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.Pad? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.Pad? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.Pad)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_PadEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.Pad>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.Pad x, global::tk2dSpriteCollectionDefinition.Pad y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.Pad x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_ColliderTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.ColliderType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.ColliderType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.ColliderType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.ColliderType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_ColliderTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.ColliderType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.ColliderType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.ColliderType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.ColliderType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_ColliderTypeEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderType>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.ColliderType x, global::tk2dSpriteCollectionDefinition.ColliderType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.ColliderType x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_PolygonColliderCapFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.PolygonColliderCap>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.PolygonColliderCap value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.PolygonColliderCap Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.PolygonColliderCap)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_PolygonColliderCapFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.PolygonColliderCap?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.PolygonColliderCap? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.PolygonColliderCap? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.PolygonColliderCap)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_PolygonColliderCapEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.PolygonColliderCap>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.PolygonColliderCap x, global::tk2dSpriteCollectionDefinition.PolygonColliderCap y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.PolygonColliderCap x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_ColliderColorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.ColliderColor>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.ColliderColor value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.ColliderColor Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.ColliderColor)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_ColliderColorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.ColliderColor?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.ColliderColor? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.ColliderColor? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.ColliderColor)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_ColliderColorEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderColor>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.ColliderColor x, global::tk2dSpriteCollectionDefinition.ColliderColor y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.ColliderColor x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_SourceFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.Source>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.Source value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.Source Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.Source)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_SourceFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.Source?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.Source? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.Source? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.Source)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_SourceEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.Source>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.Source x, global::tk2dSpriteCollectionDefinition.Source y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.Source x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_DiceFilterFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.DiceFilter>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.DiceFilter value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.DiceFilter Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.DiceFilter)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_DiceFilterFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.DiceFilter?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.DiceFilter? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.DiceFilter? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.DiceFilter)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_DiceFilterEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.DiceFilter>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.DiceFilter x, global::tk2dSpriteCollectionDefinition.DiceFilter y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.DiceFilter x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionDefinition_ColliderData_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.ColliderData.Type>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.ColliderData.Type value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionDefinition.ColliderData.Type Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionDefinition.ColliderData.Type)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionDefinition_ColliderData_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionDefinition.ColliderData.Type?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionDefinition.ColliderData.Type? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionDefinition.ColliderData.Type? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionDefinition.ColliderData.Type)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionDefinition_ColliderData_TypeEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionDefinition.ColliderData.Type>
    {
        public bool Equals(global::tk2dSpriteCollectionDefinition.ColliderData.Type x, global::tk2dSpriteCollectionDefinition.ColliderData.Type y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionDefinition.ColliderData.Type x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteSheetSource_AnchorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteSheetSource.Anchor>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteSheetSource.Anchor value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteSheetSource.Anchor Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteSheetSource.Anchor)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteSheetSource_AnchorFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteSheetSource.Anchor?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteSheetSource.Anchor? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteSheetSource.Anchor? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteSheetSource.Anchor)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteSheetSource_AnchorEqualityComparer : IEqualityComparer<global::tk2dSpriteSheetSource.Anchor>
    {
        public bool Equals(global::tk2dSpriteSheetSource.Anchor x, global::tk2dSpriteSheetSource.Anchor y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteSheetSource.Anchor x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteSheetSource_SplitMethodFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteSheetSource.SplitMethod>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteSheetSource.SplitMethod value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteSheetSource.SplitMethod Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteSheetSource.SplitMethod)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteSheetSource_SplitMethodFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteSheetSource.SplitMethod?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteSheetSource.SplitMethod? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteSheetSource.SplitMethod? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteSheetSource.SplitMethod)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteSheetSource_SplitMethodEqualityComparer : IEqualityComparer<global::tk2dSpriteSheetSource.SplitMethod>
    {
        public bool Equals(global::tk2dSpriteSheetSource.SplitMethod x, global::tk2dSpriteSheetSource.SplitMethod y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteSheetSource.SplitMethod x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollection_NormalGenerationModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollection.NormalGenerationMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollection.NormalGenerationMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollection.NormalGenerationMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollection.NormalGenerationMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollection_NormalGenerationModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollection.NormalGenerationMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollection.NormalGenerationMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollection.NormalGenerationMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollection.NormalGenerationMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollection_NormalGenerationModeEqualityComparer : IEqualityComparer<global::tk2dSpriteCollection.NormalGenerationMode>
    {
        public bool Equals(global::tk2dSpriteCollection.NormalGenerationMode x, global::tk2dSpriteCollection.NormalGenerationMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollection.NormalGenerationMode x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollection_TextureCompressionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollection.TextureCompression>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollection.TextureCompression value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollection.TextureCompression Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollection.TextureCompression)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollection_TextureCompressionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollection.TextureCompression?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollection.TextureCompression? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollection.TextureCompression? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollection.TextureCompression)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollection_TextureCompressionEqualityComparer : IEqualityComparer<global::tk2dSpriteCollection.TextureCompression>
    {
        public bool Equals(global::tk2dSpriteCollection.TextureCompression x, global::tk2dSpriteCollection.TextureCompression y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollection.TextureCompression x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollection_AtlasFormatFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollection.AtlasFormat>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollection.AtlasFormat value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollection.AtlasFormat Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollection.AtlasFormat)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollection_AtlasFormatFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollection.AtlasFormat?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollection.AtlasFormat? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollection.AtlasFormat? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollection.AtlasFormat)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollection_AtlasFormatEqualityComparer : IEqualityComparer<global::tk2dSpriteCollection.AtlasFormat>
    {
        public bool Equals(global::tk2dSpriteCollection.AtlasFormat x, global::tk2dSpriteCollection.AtlasFormat y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollection.AtlasFormat x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteColliderDefinition_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteColliderDefinition.Type>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteColliderDefinition.Type value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteColliderDefinition.Type Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteColliderDefinition.Type)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteColliderDefinition_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteColliderDefinition.Type?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteColliderDefinition.Type? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteColliderDefinition.Type? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteColliderDefinition.Type)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteColliderDefinition_TypeEqualityComparer : IEqualityComparer<global::tk2dSpriteColliderDefinition.Type>
    {
        public bool Equals(global::tk2dSpriteColliderDefinition.Type x, global::tk2dSpriteColliderDefinition.Type y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteColliderDefinition.Type x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteDefinition_ColliderTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteDefinition.ColliderType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteDefinition.ColliderType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteDefinition.ColliderType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteDefinition.ColliderType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteDefinition_ColliderTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteDefinition.ColliderType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteDefinition.ColliderType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteDefinition.ColliderType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteDefinition.ColliderType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteDefinition_ColliderTypeEqualityComparer : IEqualityComparer<global::tk2dSpriteDefinition.ColliderType>
    {
        public bool Equals(global::tk2dSpriteDefinition.ColliderType x, global::tk2dSpriteDefinition.ColliderType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteDefinition.ColliderType x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteDefinition_PhysicsEngineFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteDefinition.PhysicsEngine>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteDefinition.PhysicsEngine value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteDefinition.PhysicsEngine Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteDefinition.PhysicsEngine)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteDefinition_PhysicsEngineFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteDefinition.PhysicsEngine?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteDefinition.PhysicsEngine? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteDefinition.PhysicsEngine? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteDefinition.PhysicsEngine)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteDefinition_PhysicsEngineEqualityComparer : IEqualityComparer<global::tk2dSpriteDefinition.PhysicsEngine>
    {
        public bool Equals(global::tk2dSpriteDefinition.PhysicsEngine x, global::tk2dSpriteDefinition.PhysicsEngine y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteDefinition.PhysicsEngine x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteDefinition_FlipModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteDefinition.FlipMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteDefinition.FlipMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteDefinition.FlipMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteDefinition.FlipMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteDefinition_FlipModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteDefinition.FlipMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteDefinition.FlipMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteDefinition.FlipMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteDefinition.FlipMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteDefinition_FlipModeEqualityComparer : IEqualityComparer<global::tk2dSpriteDefinition.FlipMode>
    {
        public bool Equals(global::tk2dSpriteDefinition.FlipMode x, global::tk2dSpriteDefinition.FlipMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteDefinition.FlipMode x)
        {
            return (int)x;
        }
    }



    public class tk2dSpriteCollectionSize_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionSize.Type>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionSize.Type value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dSpriteCollectionSize.Type Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dSpriteCollectionSize.Type)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dSpriteCollectionSize_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dSpriteCollectionSize.Type?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dSpriteCollectionSize.Type? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dSpriteCollectionSize.Type? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dSpriteCollectionSize.Type)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dSpriteCollectionSize_TypeEqualityComparer : IEqualityComparer<global::tk2dSpriteCollectionSize.Type>
    {
        public bool Equals(global::tk2dSpriteCollectionSize.Type x, global::tk2dSpriteCollectionSize.Type y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dSpriteCollectionSize.Type x)
        {
            return (int)x;
        }
    }



    public class tk2dBatchedSprite_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dBatchedSprite.Type>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dBatchedSprite.Type value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dBatchedSprite.Type Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dBatchedSprite.Type)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dBatchedSprite_TypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dBatchedSprite.Type?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dBatchedSprite.Type? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dBatchedSprite.Type? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dBatchedSprite.Type)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dBatchedSprite_TypeEqualityComparer : IEqualityComparer<global::tk2dBatchedSprite.Type>
    {
        public bool Equals(global::tk2dBatchedSprite.Type x, global::tk2dBatchedSprite.Type y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dBatchedSprite.Type x)
        {
            return (int)x;
        }
    }



    public class tk2dBatchedSprite_FlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dBatchedSprite.Flags>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dBatchedSprite.Flags value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dBatchedSprite.Flags Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dBatchedSprite.Flags)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dBatchedSprite_FlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dBatchedSprite.Flags?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dBatchedSprite.Flags? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dBatchedSprite.Flags? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dBatchedSprite.Flags)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dBatchedSprite_FlagsEqualityComparer : IEqualityComparer<global::tk2dBatchedSprite.Flags>
    {
        public bool Equals(global::tk2dBatchedSprite.Flags x, global::tk2dBatchedSprite.Flags y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dBatchedSprite.Flags x)
        {
            return (int)x;
        }
    }



    public class tk2dStaticSpriteBatcher_FlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dStaticSpriteBatcher.Flags>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dStaticSpriteBatcher.Flags value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dStaticSpriteBatcher.Flags Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dStaticSpriteBatcher.Flags)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dStaticSpriteBatcher_FlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dStaticSpriteBatcher.Flags?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dStaticSpriteBatcher.Flags? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dStaticSpriteBatcher.Flags? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dStaticSpriteBatcher.Flags)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dStaticSpriteBatcher_FlagsEqualityComparer : IEqualityComparer<global::tk2dStaticSpriteBatcher.Flags>
    {
        public bool Equals(global::tk2dStaticSpriteBatcher.Flags x, global::tk2dStaticSpriteBatcher.Flags y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dStaticSpriteBatcher.Flags x)
        {
            return (int)x;
        }
    }



    public class tk2dTileFlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileFlags>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileFlags value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dTileFlags Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dTileFlags)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dTileFlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileFlags?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileFlags? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dTileFlags? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dTileFlags)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dTileFlagsEqualityComparer : IEqualityComparer<global::tk2dTileFlags>
    {
        public bool Equals(global::tk2dTileFlags x, global::tk2dTileFlags y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dTileFlags x)
        {
            return (int)x;
        }
    }



    public class tk2dTileMap_BuildFlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMap.BuildFlags>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMap.BuildFlags value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dTileMap.BuildFlags Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dTileMap.BuildFlags)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dTileMap_BuildFlagsFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMap.BuildFlags?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMap.BuildFlags? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dTileMap.BuildFlags? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dTileMap.BuildFlags)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dTileMap_BuildFlagsEqualityComparer : IEqualityComparer<global::tk2dTileMap.BuildFlags>
    {
        public bool Equals(global::tk2dTileMap.BuildFlags x, global::tk2dTileMap.BuildFlags y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dTileMap.BuildFlags x)
        {
            return (int)x;
        }
    }



    public class tk2dTileMapData_SortMethodFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMapData.SortMethod>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMapData.SortMethod value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dTileMapData.SortMethod Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dTileMapData.SortMethod)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dTileMapData_SortMethodFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMapData.SortMethod?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMapData.SortMethod? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dTileMapData.SortMethod? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dTileMapData.SortMethod)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dTileMapData_SortMethodEqualityComparer : IEqualityComparer<global::tk2dTileMapData.SortMethod>
    {
        public bool Equals(global::tk2dTileMapData.SortMethod x, global::tk2dTileMapData.SortMethod y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dTileMapData.SortMethod x)
        {
            return (int)x;
        }
    }



    public class tk2dTileMapData_TileTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMapData.TileType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMapData.TileType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dTileMapData.TileType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dTileMapData.TileType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dTileMapData_TileTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMapData.TileType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMapData.TileType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dTileMapData.TileType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dTileMapData.TileType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dTileMapData_TileTypeEqualityComparer : IEqualityComparer<global::tk2dTileMapData.TileType>
    {
        public bool Equals(global::tk2dTileMapData.TileType x, global::tk2dTileMapData.TileType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dTileMapData.TileType x)
        {
            return (int)x;
        }
    }



    public class tk2dTileMapData_ColorModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMapData.ColorMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMapData.ColorMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dTileMapData.ColorMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dTileMapData.ColorMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dTileMapData_ColorModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dTileMapData.ColorMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dTileMapData.ColorMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dTileMapData.ColorMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dTileMapData.ColorMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dTileMapData_ColorModeEqualityComparer : IEqualityComparer<global::tk2dTileMapData.ColorMode>
    {
        public bool Equals(global::tk2dTileMapData.ColorMode x, global::tk2dTileMapData.ColorMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dTileMapData.ColorMode x)
        {
            return (int)x;
        }
    }



    public class tk2dUIScrollableArea_AxesFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dUIScrollableArea.Axes>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dUIScrollableArea.Axes value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dUIScrollableArea.Axes Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dUIScrollableArea.Axes)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dUIScrollableArea_AxesFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dUIScrollableArea.Axes?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dUIScrollableArea.Axes? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dUIScrollableArea.Axes? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dUIScrollableArea.Axes)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dUIScrollableArea_AxesEqualityComparer : IEqualityComparer<global::tk2dUIScrollableArea.Axes>
    {
        public bool Equals(global::tk2dUIScrollableArea.Axes x, global::tk2dUIScrollableArea.Axes y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dUIScrollableArea.Axes x)
        {
            return (int)x;
        }
    }



    public class tk2dUIScrollbar_AxesFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dUIScrollbar.Axes>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dUIScrollbar.Axes value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dUIScrollbar.Axes Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dUIScrollbar.Axes)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dUIScrollbar_AxesFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dUIScrollbar.Axes?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dUIScrollbar.Axes? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dUIScrollbar.Axes? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dUIScrollbar.Axes)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dUIScrollbar_AxesEqualityComparer : IEqualityComparer<global::tk2dUIScrollbar.Axes>
    {
        public bool Equals(global::tk2dUIScrollbar.Axes x, global::tk2dUIScrollbar.Axes y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dUIScrollbar.Axes x)
        {
            return (int)x;
        }
    }



    public class tk2dUICamera_tk2dRaycastTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dUICamera.tk2dRaycastType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dUICamera.tk2dRaycastType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::tk2dUICamera.tk2dRaycastType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::tk2dUICamera.tk2dRaycastType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class Nullabletk2dUICamera_tk2dRaycastTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::tk2dUICamera.tk2dRaycastType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::tk2dUICamera.tk2dRaycastType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::tk2dUICamera.tk2dRaycastType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::tk2dUICamera.tk2dRaycastType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class tk2dUICamera_tk2dRaycastTypeEqualityComparer : IEqualityComparer<global::tk2dUICamera.tk2dRaycastType>
    {
        public bool Equals(global::tk2dUICamera.tk2dRaycastType x, global::tk2dUICamera.tk2dRaycastType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::tk2dUICamera.tk2dRaycastType x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.AnimationOrTween
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class TriggerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.Trigger>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.Trigger value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::AnimationOrTween.Trigger Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::AnimationOrTween.Trigger)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableTriggerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.Trigger?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.Trigger? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::AnimationOrTween.Trigger? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::AnimationOrTween.Trigger)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class TriggerEqualityComparer : IEqualityComparer<global::AnimationOrTween.Trigger>
    {
        public bool Equals(global::AnimationOrTween.Trigger x, global::AnimationOrTween.Trigger y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::AnimationOrTween.Trigger x)
        {
            return (int)x;
        }
    }



    public class DirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.Direction>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.Direction value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::AnimationOrTween.Direction Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::AnimationOrTween.Direction)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.Direction?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.Direction? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::AnimationOrTween.Direction? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::AnimationOrTween.Direction)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class DirectionEqualityComparer : IEqualityComparer<global::AnimationOrTween.Direction>
    {
        public bool Equals(global::AnimationOrTween.Direction x, global::AnimationOrTween.Direction y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::AnimationOrTween.Direction x)
        {
            return (int)x;
        }
    }



    public class EnableConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.EnableCondition>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.EnableCondition value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::AnimationOrTween.EnableCondition Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::AnimationOrTween.EnableCondition)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableEnableConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.EnableCondition?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.EnableCondition? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::AnimationOrTween.EnableCondition? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::AnimationOrTween.EnableCondition)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class EnableConditionEqualityComparer : IEqualityComparer<global::AnimationOrTween.EnableCondition>
    {
        public bool Equals(global::AnimationOrTween.EnableCondition x, global::AnimationOrTween.EnableCondition y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::AnimationOrTween.EnableCondition x)
        {
            return (int)x;
        }
    }



    public class DisableConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.DisableCondition>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.DisableCondition value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::AnimationOrTween.DisableCondition Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::AnimationOrTween.DisableCondition)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableDisableConditionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::AnimationOrTween.DisableCondition?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::AnimationOrTween.DisableCondition? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::AnimationOrTween.DisableCondition? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::AnimationOrTween.DisableCondition)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class DisableConditionEqualityComparer : IEqualityComparer<global::AnimationOrTween.DisableCondition>
    {
        public bool Equals(global::AnimationOrTween.DisableCondition x, global::AnimationOrTween.DisableCondition y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::AnimationOrTween.DisableCondition x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.MessagePack
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class TinyJsonTokenFormatter<TTypeResolver> : Formatter<TTypeResolver, global::MessagePack.TinyJsonToken>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::MessagePack.TinyJsonToken value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::MessagePack.TinyJsonToken Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::MessagePack.TinyJsonToken)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableTinyJsonTokenFormatter<TTypeResolver> : Formatter<TTypeResolver, global::MessagePack.TinyJsonToken?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::MessagePack.TinyJsonToken? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::MessagePack.TinyJsonToken? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::MessagePack.TinyJsonToken)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class TinyJsonTokenEqualityComparer : IEqualityComparer<global::MessagePack.TinyJsonToken>
    {
        public bool Equals(global::MessagePack.TinyJsonToken x, global::MessagePack.TinyJsonToken y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::MessagePack.TinyJsonToken x)
        {
            return (int)x;
        }
    }



    public class ValueTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::MessagePack.ValueType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 1;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::MessagePack.ValueType value)
        {
            return BinaryUtil.WriteByte(ref bytes, offset, (Byte)value);
        }

        public override global::MessagePack.ValueType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            return (global::MessagePack.ValueType)BinaryUtil.ReadByte(ref bytes, offset);
        }
    }


    public class NullableValueTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::MessagePack.ValueType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 2;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::MessagePack.ValueType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteByte(ref bytes, offset + 1, (Byte)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 2);
            }

            return 2;
        }

        public override global::MessagePack.ValueType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 2;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::MessagePack.ValueType)BinaryUtil.ReadByte(ref bytes, offset + 1);
        }
    }



    public class ValueTypeEqualityComparer : IEqualityComparer<global::MessagePack.ValueType>
    {
        public bool Equals(global::MessagePack.ValueType x, global::MessagePack.ValueType y)
        {
            return (Byte)x == (Byte)y;
        }

        public int GetHashCode(global::MessagePack.ValueType x)
        {
            return (int)(Byte)x;
        }
    }



    public class MessagePackTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::MessagePack.MessagePackType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 1;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::MessagePack.MessagePackType value)
        {
            return BinaryUtil.WriteByte(ref bytes, offset, (Byte)value);
        }

        public override global::MessagePack.MessagePackType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            return (global::MessagePack.MessagePackType)BinaryUtil.ReadByte(ref bytes, offset);
        }
    }


    public class NullableMessagePackTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::MessagePack.MessagePackType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 2;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::MessagePack.MessagePackType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteByte(ref bytes, offset + 1, (Byte)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 2);
            }

            return 2;
        }

        public override global::MessagePack.MessagePackType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 2;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::MessagePack.MessagePackType)BinaryUtil.ReadByte(ref bytes, offset + 1);
        }
    }



    public class MessagePackTypeEqualityComparer : IEqualityComparer<global::MessagePack.MessagePackType>
    {
        public bool Equals(global::MessagePack.MessagePackType x, global::MessagePack.MessagePackType y)
        {
            return (Byte)x == (Byte)y;
        }

        public int GetHashCode(global::MessagePack.MessagePackType x)
        {
            return (int)(Byte)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Pathfinding
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class GraphUpdateThreadingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GraphUpdateThreading>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GraphUpdateThreading value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.GraphUpdateThreading Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.GraphUpdateThreading)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableGraphUpdateThreadingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GraphUpdateThreading?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GraphUpdateThreading? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.GraphUpdateThreading? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.GraphUpdateThreading)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class GraphUpdateThreadingEqualityComparer : IEqualityComparer<global::Pathfinding.GraphUpdateThreading>
    {
        public bool Equals(global::Pathfinding.GraphUpdateThreading x, global::Pathfinding.GraphUpdateThreading y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.GraphUpdateThreading x)
        {
            return (int)x;
        }
    }



    public class PathLogFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.PathLog>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.PathLog value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.PathLog Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.PathLog)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullablePathLogFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.PathLog?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.PathLog? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.PathLog? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.PathLog)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class PathLogEqualityComparer : IEqualityComparer<global::Pathfinding.PathLog>
    {
        public bool Equals(global::Pathfinding.PathLog x, global::Pathfinding.PathLog y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.PathLog x)
        {
            return (int)x;
        }
    }



    public class HeuristicFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.Heuristic>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.Heuristic value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.Heuristic Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.Heuristic)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableHeuristicFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.Heuristic?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.Heuristic? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.Heuristic? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.Heuristic)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class HeuristicEqualityComparer : IEqualityComparer<global::Pathfinding.Heuristic>
    {
        public bool Equals(global::Pathfinding.Heuristic x, global::Pathfinding.Heuristic y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.Heuristic x)
        {
            return (int)x;
        }
    }



    public class GraphDebugModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GraphDebugMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GraphDebugMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.GraphDebugMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.GraphDebugMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableGraphDebugModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GraphDebugMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GraphDebugMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.GraphDebugMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.GraphDebugMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class GraphDebugModeEqualityComparer : IEqualityComparer<global::Pathfinding.GraphDebugMode>
    {
        public bool Equals(global::Pathfinding.GraphDebugMode x, global::Pathfinding.GraphDebugMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.GraphDebugMode x)
        {
            return (int)x;
        }
    }



    public class ThreadCountFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.ThreadCount>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.ThreadCount value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.ThreadCount Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.ThreadCount)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableThreadCountFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.ThreadCount?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.ThreadCount? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.ThreadCount? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.ThreadCount)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class ThreadCountEqualityComparer : IEqualityComparer<global::Pathfinding.ThreadCount>
    {
        public bool Equals(global::Pathfinding.ThreadCount x, global::Pathfinding.ThreadCount y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.ThreadCount x)
        {
            return (int)x;
        }
    }



    public class PathStateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.PathState>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.PathState value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.PathState Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.PathState)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullablePathStateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.PathState?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.PathState? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.PathState? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.PathState)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class PathStateEqualityComparer : IEqualityComparer<global::Pathfinding.PathState>
    {
        public bool Equals(global::Pathfinding.PathState x, global::Pathfinding.PathState y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.PathState x)
        {
            return (int)x;
        }
    }



    public class PathCompleteStateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.PathCompleteState>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.PathCompleteState value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.PathCompleteState Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.PathCompleteState)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullablePathCompleteStateFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.PathCompleteState?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.PathCompleteState? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.PathCompleteState? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.PathCompleteState)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class PathCompleteStateEqualityComparer : IEqualityComparer<global::Pathfinding.PathCompleteState>
    {
        public bool Equals(global::Pathfinding.PathCompleteState x, global::Pathfinding.PathCompleteState y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.PathCompleteState x)
        {
            return (int)x;
        }
    }



    public class GraphModifier_EventTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GraphModifier.EventType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GraphModifier.EventType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.GraphModifier.EventType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.GraphModifier.EventType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableGraphModifier_EventTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GraphModifier.EventType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GraphModifier.EventType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.GraphModifier.EventType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.GraphModifier.EventType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class GraphModifier_EventTypeEqualityComparer : IEqualityComparer<global::Pathfinding.GraphModifier.EventType>
    {
        public bool Equals(global::Pathfinding.GraphModifier.EventType x, global::Pathfinding.GraphModifier.EventType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.GraphModifier.EventType x)
        {
            return (int)x;
        }
    }



    public class ColliderTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.ColliderType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.ColliderType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.ColliderType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.ColliderType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableColliderTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.ColliderType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.ColliderType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.ColliderType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.ColliderType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class ColliderTypeEqualityComparer : IEqualityComparer<global::Pathfinding.ColliderType>
    {
        public bool Equals(global::Pathfinding.ColliderType x, global::Pathfinding.ColliderType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.ColliderType x)
        {
            return (int)x;
        }
    }



    public class RayDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RayDirection>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RayDirection value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.RayDirection Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.RayDirection)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableRayDirectionFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RayDirection?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RayDirection? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.RayDirection? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.RayDirection)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class RayDirectionEqualityComparer : IEqualityComparer<global::Pathfinding.RayDirection>
    {
        public bool Equals(global::Pathfinding.RayDirection x, global::Pathfinding.RayDirection y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.RayDirection x)
        {
            return (int)x;
        }
    }



    public class GridGraph_TextureData_ChannelUseFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GridGraph.TextureData.ChannelUse>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GridGraph.TextureData.ChannelUse value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.GridGraph.TextureData.ChannelUse Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.GridGraph.TextureData.ChannelUse)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableGridGraph_TextureData_ChannelUseFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.GridGraph.TextureData.ChannelUse?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.GridGraph.TextureData.ChannelUse? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.GridGraph.TextureData.ChannelUse? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.GridGraph.TextureData.ChannelUse)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class GridGraph_TextureData_ChannelUseEqualityComparer : IEqualityComparer<global::Pathfinding.GridGraph.TextureData.ChannelUse>
    {
        public bool Equals(global::Pathfinding.GridGraph.TextureData.ChannelUse x, global::Pathfinding.GridGraph.TextureData.ChannelUse y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.GridGraph.TextureData.ChannelUse x)
        {
            return (int)x;
        }
    }



    public class NumNeighboursFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.NumNeighbours>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.NumNeighbours value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.NumNeighbours Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.NumNeighbours)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableNumNeighboursFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.NumNeighbours?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.NumNeighbours? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.NumNeighbours? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.NumNeighbours)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class NumNeighboursEqualityComparer : IEqualityComparer<global::Pathfinding.NumNeighbours>
    {
        public bool Equals(global::Pathfinding.NumNeighbours x, global::Pathfinding.NumNeighbours y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.NumNeighbours x)
        {
            return (int)x;
        }
    }



    public class RecastGraph_RelevantGraphSurfaceModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableRecastGraph_RelevantGraphSurfaceModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class RecastGraph_RelevantGraphSurfaceModeEqualityComparer : IEqualityComparer<global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode>
    {
        public bool Equals(global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode x, global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.RecastGraph.RelevantGraphSurfaceMode x)
        {
            return (int)x;
        }
    }



    public class HeuristicOptimizationModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.HeuristicOptimizationMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.HeuristicOptimizationMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.HeuristicOptimizationMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.HeuristicOptimizationMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableHeuristicOptimizationModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.HeuristicOptimizationMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.HeuristicOptimizationMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.HeuristicOptimizationMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.HeuristicOptimizationMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class HeuristicOptimizationModeEqualityComparer : IEqualityComparer<global::Pathfinding.HeuristicOptimizationMode>
    {
        public bool Equals(global::Pathfinding.HeuristicOptimizationMode x, global::Pathfinding.HeuristicOptimizationMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.HeuristicOptimizationMode x)
        {
            return (int)x;
        }
    }



    public class SimpleSmoothModifier_SmoothTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.SimpleSmoothModifier.SmoothType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.SimpleSmoothModifier.SmoothType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.SimpleSmoothModifier.SmoothType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.SimpleSmoothModifier.SmoothType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableSimpleSmoothModifier_SmoothTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.SimpleSmoothModifier.SmoothType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.SimpleSmoothModifier.SmoothType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.SimpleSmoothModifier.SmoothType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.SimpleSmoothModifier.SmoothType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class SimpleSmoothModifier_SmoothTypeEqualityComparer : IEqualityComparer<global::Pathfinding.SimpleSmoothModifier.SmoothType>
    {
        public bool Equals(global::Pathfinding.SimpleSmoothModifier.SmoothType x, global::Pathfinding.SimpleSmoothModifier.SmoothType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.SimpleSmoothModifier.SmoothType x)
        {
            return (int)x;
        }
    }



    public class StartEndModifier_ExactnessFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.StartEndModifier.Exactness>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.StartEndModifier.Exactness value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.StartEndModifier.Exactness Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.StartEndModifier.Exactness)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableStartEndModifier_ExactnessFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.StartEndModifier.Exactness?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.StartEndModifier.Exactness? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.StartEndModifier.Exactness? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.StartEndModifier.Exactness)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class StartEndModifier_ExactnessEqualityComparer : IEqualityComparer<global::Pathfinding.StartEndModifier.Exactness>
    {
        public bool Equals(global::Pathfinding.StartEndModifier.Exactness x, global::Pathfinding.StartEndModifier.Exactness y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.StartEndModifier.Exactness x)
        {
            return (int)x;
        }
    }



    public class NavmeshAdd_MeshTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.NavmeshAdd.MeshType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.NavmeshAdd.MeshType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.NavmeshAdd.MeshType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.NavmeshAdd.MeshType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableNavmeshAdd_MeshTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.NavmeshAdd.MeshType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.NavmeshAdd.MeshType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.NavmeshAdd.MeshType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.NavmeshAdd.MeshType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class NavmeshAdd_MeshTypeEqualityComparer : IEqualityComparer<global::Pathfinding.NavmeshAdd.MeshType>
    {
        public bool Equals(global::Pathfinding.NavmeshAdd.MeshType x, global::Pathfinding.NavmeshAdd.MeshType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.NavmeshAdd.MeshType x)
        {
            return (int)x;
        }
    }



    public class NavmeshCut_MeshTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.NavmeshCut.MeshType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.NavmeshCut.MeshType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.NavmeshCut.MeshType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.NavmeshCut.MeshType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableNavmeshCut_MeshTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.NavmeshCut.MeshType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.NavmeshCut.MeshType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.NavmeshCut.MeshType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.NavmeshCut.MeshType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class NavmeshCut_MeshTypeEqualityComparer : IEqualityComparer<global::Pathfinding.NavmeshCut.MeshType>
    {
        public bool Equals(global::Pathfinding.NavmeshCut.MeshType x, global::Pathfinding.NavmeshCut.MeshType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.NavmeshCut.MeshType x)
        {
            return (int)x;
        }
    }



    public class MultiTargetPath_HeuristicModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.MultiTargetPath.HeuristicMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.MultiTargetPath.HeuristicMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.MultiTargetPath.HeuristicMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.MultiTargetPath.HeuristicMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableMultiTargetPath_HeuristicModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.MultiTargetPath.HeuristicMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.MultiTargetPath.HeuristicMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.MultiTargetPath.HeuristicMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.MultiTargetPath.HeuristicMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class MultiTargetPath_HeuristicModeEqualityComparer : IEqualityComparer<global::Pathfinding.MultiTargetPath.HeuristicMode>
    {
        public bool Equals(global::Pathfinding.MultiTargetPath.HeuristicMode x, global::Pathfinding.MultiTargetPath.HeuristicMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.MultiTargetPath.HeuristicMode x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Pathfinding.RVO
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class MovementPlaneFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RVO.MovementPlane>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RVO.MovementPlane value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.RVO.MovementPlane Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.RVO.MovementPlane)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableMovementPlaneFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RVO.MovementPlane?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RVO.MovementPlane? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.RVO.MovementPlane? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.RVO.MovementPlane)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class MovementPlaneEqualityComparer : IEqualityComparer<global::Pathfinding.RVO.MovementPlane>
    {
        public bool Equals(global::Pathfinding.RVO.MovementPlane x, global::Pathfinding.RVO.MovementPlane y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.RVO.MovementPlane x)
        {
            return (int)x;
        }
    }



    public class RVOLayerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RVO.RVOLayer>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RVO.RVOLayer value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.RVO.RVOLayer Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.RVO.RVOLayer)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableRVOLayerFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RVO.RVOLayer?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RVO.RVOLayer? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.RVO.RVOLayer? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.RVO.RVOLayer)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class RVOLayerEqualityComparer : IEqualityComparer<global::Pathfinding.RVO.RVOLayer>
    {
        public bool Equals(global::Pathfinding.RVO.RVOLayer x, global::Pathfinding.RVO.RVOLayer y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.RVO.RVOLayer x)
        {
            return (int)x;
        }
    }



    public class RVOObstacle_ObstacleVertexWindingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableRVOObstacle_ObstacleVertexWindingFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class RVOObstacle_ObstacleVertexWindingEqualityComparer : IEqualityComparer<global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding>
    {
        public bool Equals(global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding x, global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.RVO.RVOObstacle.ObstacleVertexWinding x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.Pathfinding.Util
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class TileHandler_CutModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.Util.TileHandler.CutMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.Util.TileHandler.CutMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::Pathfinding.Util.TileHandler.CutMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::Pathfinding.Util.TileHandler.CutMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableTileHandler_CutModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::Pathfinding.Util.TileHandler.CutMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::Pathfinding.Util.TileHandler.CutMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::Pathfinding.Util.TileHandler.CutMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::Pathfinding.Util.TileHandler.CutMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class TileHandler_CutModeEqualityComparer : IEqualityComparer<global::Pathfinding.Util.TileHandler.CutMode>
    {
        public bool Equals(global::Pathfinding.Util.TileHandler.CutMode x, global::Pathfinding.Util.TileHandler.CutMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::Pathfinding.Util.TileHandler.CutMode x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168
namespace ZeroFormatter.DynamicObjectSegments.UniRx
{
    using global::System;
    using global::System.Collections.Generic;
    using global::ZeroFormatter.Formatters;
    using global::ZeroFormatter.Internal;
    using global::ZeroFormatter.Segments;


    public class NotificationKindFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.NotificationKind>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.NotificationKind value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UniRx.NotificationKind Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UniRx.NotificationKind)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableNotificationKindFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.NotificationKind?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.NotificationKind? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UniRx.NotificationKind? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UniRx.NotificationKind)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class NotificationKindEqualityComparer : IEqualityComparer<global::UniRx.NotificationKind>
    {
        public bool Equals(global::UniRx.NotificationKind x, global::UniRx.NotificationKind y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UniRx.NotificationKind x)
        {
            return (int)x;
        }
    }



    public class CountChangedStatusFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.CountChangedStatus>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.CountChangedStatus value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UniRx.CountChangedStatus Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UniRx.CountChangedStatus)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableCountChangedStatusFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.CountChangedStatus?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.CountChangedStatus? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UniRx.CountChangedStatus? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UniRx.CountChangedStatus)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class CountChangedStatusEqualityComparer : IEqualityComparer<global::UniRx.CountChangedStatus>
    {
        public bool Equals(global::UniRx.CountChangedStatus x, global::UniRx.CountChangedStatus y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UniRx.CountChangedStatus x)
        {
            return (int)x;
        }
    }



    public class LazyTask_TaskStatusFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.LazyTask.TaskStatus>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.LazyTask.TaskStatus value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UniRx.LazyTask.TaskStatus Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UniRx.LazyTask.TaskStatus)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableLazyTask_TaskStatusFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.LazyTask.TaskStatus?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.LazyTask.TaskStatus? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UniRx.LazyTask.TaskStatus? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UniRx.LazyTask.TaskStatus)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class LazyTask_TaskStatusEqualityComparer : IEqualityComparer<global::UniRx.LazyTask.TaskStatus>
    {
        public bool Equals(global::UniRx.LazyTask.TaskStatus x, global::UniRx.LazyTask.TaskStatus y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UniRx.LazyTask.TaskStatus x)
        {
            return (int)x;
        }
    }



    public class MainThreadDispatcher_CullingModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.MainThreadDispatcher.CullingMode>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.MainThreadDispatcher.CullingMode value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UniRx.MainThreadDispatcher.CullingMode Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UniRx.MainThreadDispatcher.CullingMode)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableMainThreadDispatcher_CullingModeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.MainThreadDispatcher.CullingMode?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.MainThreadDispatcher.CullingMode? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UniRx.MainThreadDispatcher.CullingMode? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UniRx.MainThreadDispatcher.CullingMode)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class MainThreadDispatcher_CullingModeEqualityComparer : IEqualityComparer<global::UniRx.MainThreadDispatcher.CullingMode>
    {
        public bool Equals(global::UniRx.MainThreadDispatcher.CullingMode x, global::UniRx.MainThreadDispatcher.CullingMode y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UniRx.MainThreadDispatcher.CullingMode x)
        {
            return (int)x;
        }
    }



    public class FrameCountTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.FrameCountType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.FrameCountType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UniRx.FrameCountType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UniRx.FrameCountType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableFrameCountTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.FrameCountType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.FrameCountType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UniRx.FrameCountType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UniRx.FrameCountType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class FrameCountTypeEqualityComparer : IEqualityComparer<global::UniRx.FrameCountType>
    {
        public bool Equals(global::UniRx.FrameCountType x, global::UniRx.FrameCountType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UniRx.FrameCountType x)
        {
            return (int)x;
        }
    }



    public class MainThreadDispatchTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.MainThreadDispatchType>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 4;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.MainThreadDispatchType value)
        {
            return BinaryUtil.WriteInt32(ref bytes, offset, (Int32)value);
        }

        public override global::UniRx.MainThreadDispatchType Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 4;
            return (global::UniRx.MainThreadDispatchType)BinaryUtil.ReadInt32(ref bytes, offset);
        }
    }


    public class NullableMainThreadDispatchTypeFormatter<TTypeResolver> : Formatter<TTypeResolver, global::UniRx.MainThreadDispatchType?>
        where TTypeResolver : ITypeResolver, new()
    {
        public override int? GetLength()
        {
            return 5;
        }

        public override int Serialize(ref byte[] bytes, int offset, global::UniRx.MainThreadDispatchType? value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value.HasValue);
            if (value.HasValue)
            {
                BinaryUtil.WriteInt32(ref bytes, offset + 1, (Int32)value.Value);
            }
            else
            {
                BinaryUtil.EnsureCapacity(ref bytes, offset, offset + 5);
            }

            return 5;
        }

        public override global::UniRx.MainThreadDispatchType? Deserialize(ref byte[] bytes, int offset, global::ZeroFormatter.DirtyTracker tracker, out int byteSize)
        {
            byteSize = 5;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;

            return (global::UniRx.MainThreadDispatchType)BinaryUtil.ReadInt32(ref bytes, offset + 1);
        }
    }



    public class MainThreadDispatchTypeEqualityComparer : IEqualityComparer<global::UniRx.MainThreadDispatchType>
    {
        public bool Equals(global::UniRx.MainThreadDispatchType x, global::UniRx.MainThreadDispatchType y)
        {
            return (Int32)x == (Int32)y;
        }

        public int GetHashCode(global::UniRx.MainThreadDispatchType x)
        {
            return (int)x;
        }
    }



}
#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
