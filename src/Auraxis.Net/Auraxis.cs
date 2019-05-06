namespace Auraxis.Net
{
    public static class Auraxis
    {
        public static AuraxisClient PC => pc ?? (pc = new AuraxisClient(Platform.PC));
        public static AuraxisClient PS4_EU => ps4eu ?? (ps4eu = new AuraxisClient(Platform.PS4_EU));
        public static AuraxisClient PS4_US => ps4us ?? (ps4us = new AuraxisClient(Platform.PS4_US));

        private static AuraxisClient pc;
        private static AuraxisClient ps4eu;
        private static AuraxisClient ps4us;
    }
}
