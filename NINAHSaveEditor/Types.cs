using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NINAHSaveEditor {
    public static class Types {
        private static string Crap = 
            ", Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

        public static string ConsumablesController = "_Code.Infrastructure.Consumables.ConsumablesController";
        public static string ConsumablesSavesData = ConsumablesController + Crap;
        public static string StateObjectController = "_Code.Infrastructure.StateObjects.StateObjectController";
        public static string StateObjectSavesData = StateObjectController + Crap;
    }
}
