using System;

namespace Martin_Dialer
{
    // Jordan Martin 
    // IT112
    // NOTES: Some of the instructions were unclear to me such as No static methods allowed within any of these three classes. I didn't know how to make main non static. 
    // Apologies if I'm missing some requirements. I now transitoned from a full time to a part time job. I know this isnt my best work and I will do better on the next assignment.
    // BEHAVIORS NOT IMPLIMENTED AND WHY: I did not create a method to check the phone spacing since the data matches the format already.

    class Phone
    {
        private static string[] buisnessName = { "CompuTest", "Curtis Manufacturing", "Data Functions", "Donnay Repair", "ErgoNomic Inc", "ErgoSource", "Fox Bay Industries", "Glare-Guard", "Hazard Comm Specialists", "Komfort Support" };
        private static string[] phoneNumber = { "(303) 985-5060", "(603) 532-4123", "(800) 876-2524", "(708) 397-3330", "(360) 434-3894", "(800) 969-4374", "(800) 874-8527", "(800) 545-6254", "(407) 783-6641", "(714) 472-4409" };
        private static int[] homeorCell = { 1, 2, 1, 1, 1, 1, 2, 2, 2, 2 };

        static void Main(string[] args)
        {
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (homeorCell[i] == 1)
                {
                    CellPhone cp = new CellPhone(phoneNumber[i], buisnessName[i], homeorCell[i].ToString());
                    Console.WriteLine(buisnessName[i] + " is being dialed using " + cp.Dial(phoneNumber[i]));
                }
                else
                {
                    HomePhone hp = new HomePhone(phoneNumber[i], buisnessName[i], homeorCell[i].ToString());
                    Console.WriteLine(buisnessName[i] + " is being dialed using " + hp.Dial(phoneNumber[i]));
                }
            }
        }
        public virtual string Dial(string phone)
        {
            return phone;
        }

    }
}
