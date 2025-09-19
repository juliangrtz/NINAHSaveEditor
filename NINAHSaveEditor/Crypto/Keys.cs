using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NINAHSaveEditor.Crypto {
    public static class Keys {
        // Must be reverse-engineered from the game's code.
        // v1 until v1.1.13
        public static readonly byte[] Latest = Encoding.UTF8.GetBytes("e38c9861b43264e37c1eef64d7925dde");
    }
}
