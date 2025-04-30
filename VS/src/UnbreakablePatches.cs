using Il2CppTLD.Placement;

namespace SaveSavior
{
    internal class UnbreakablePatches
    {
        [HarmonyPatch(typeof(PlaceableManager), nameof(PlaceableManager.DeserializeInventory))]
        private static class DeleteNullsFromInventory
        {
            internal static void Prefix(ref Il2CppSystem.Collections.Generic.List<PlaceableInfoSaveData> placeableInventory)
            {
                Il2CppSystem.Collections.Generic.List<PlaceableInfoSaveData> cleanedList = new();

                foreach (PlaceableInfoSaveData pisd in placeableInventory)
                {
                    if (pisd != null && !string.IsNullOrEmpty(pisd.m_Guid))
                    {
                        if (PlaceableManager.s_Placeables.ContainsKey(pisd.m_Guid) && PlaceableManager.s_Placeables[pisd.m_Guid] != null)
                        {
                            cleanedList.Add(pisd);
                        }
                    }
                }

                if (cleanedList.Count != placeableInventory.Count)
                {
                    Log(CC.Red, $"Found and removed invalid decoration items: {placeableInventory.Count - cleanedList.Count}");
                    placeableInventory = cleanedList;
                }
            }
        }
    }
}
 