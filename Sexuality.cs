using System;
using System.Collections.Generic;
using System.Text;

namespace Memes
{
    class Sexuality
    {
        private float sex_male;
        private float sex_female;
        private float sex_enby;

        private float rom_male;
        private float rom_female;
        private float rom_enby;

        private float sex_intensity;
        private float rom_intensity;

        public Sexuality()
        {
            this.sex_male = 0f;
            this.sex_female = 0f;
            this.sex_enby = 0f;

            this.rom_male = 0f;
            this.rom_female = 0f;
            this.rom_enby = 0f;

            this.sex_intensity = 0f;
            this.rom_intensity = 0f;
        }

        public Sexuality(float sM, float sF, float sE, float sI, float rM, float rF, float rE, float rI)
        {
            this.sex_male = sM;
            this.sex_female = sF;
            this.sex_enby = sE;

            this.rom_male = rM;
            this.rom_female = rF;
            this.rom_enby = rE;

            this.sex_intensity = sI;
            this.rom_intensity = rI;
        }

        public float getSex_male() { return sex_male; }
        public float getSex_female() { return sex_female; }
        public float getSex_enby() { return sex_enby; }

        public float getRom_male() { return rom_male; }
        public float getRom_female() { return rom_female; }
        public float getRom_enby() { return rom_enby; }

        public float getSex_intensity() { return sex_intensity; }
        public float getRom_intensity() { return rom_intensity; }

        public string getSexualAttraction()
        {
            if (sex_male == 1f && sex_female == 0f && sex_enby == 0f)
            {
                return "Andro-Sexual";
            }
            else if (sex_male == 0f && sex_female == 1f && sex_enby == 0f)
            {
                return "Gyne-Sexual";
            }
            else if (sex_male == 0f && sex_female == 0f && sex_enby == 1f)
            {
                return "Skolio-Sexual";
            }
            else if ((sex_male == 0f && sex_female == 0f && sex_enby == 0f) || sex_intensity == 0f)
            {
                return "Asexual";
            }
            else
            {
                return "Unknown";
            }
        }

        public string getRomanticAttraction()
        {
            if (rom_male == 1f && rom_female == 0f && rom_enby == 0f)
            {
                return "Andro-Romantic";
            }
            else if (rom_male == 0f && rom_female == 1f && rom_enby == 0f)
            {
                return "Gyne-Romantic";
            }
            else if (rom_male == 0f && rom_female == 0f && rom_enby == 1f)
            {
                return "Skolio-Romantic";
            }
            else if ((rom_male == 0f && rom_female == 0f && rom_enby == 0f) || rom_intensity == 0f)
            {
                return "Aromantic";
            }
            else
            {
                return "Unknown";
            }
        }

        public String getAttraction()
        {
            String romAtt = getRomanticAttraction();
            String sexAtt = getSexualAttraction();

            if (romAtt.Equals("Aromantic") && sexAtt.Equals("Asexual"))
            {
                return "AroAce";
            }
            else
            {
                return romAtt + " " + sexAtt;
            }
        }

        public override String ToString()
        {
            return "Sexual Attraction: " + getSexualAttraction() + "\n" +
                    "  Male      : " + sex_male + ",\n" +
                    "  Female    : " + sex_female + ",\n" +
                    "  Enby      : " + sex_enby + ",\n" +
                    "  Intensity : " + sex_intensity + "\n" +
                    "Romantic Attraction: " + getRomanticAttraction() + "\n" +
                    "  Male      : " + rom_male + ",\n" +
                    "  Female    : " + rom_female + ",\n" +
                    "  Enby      : " + rom_enby + ",\n" +
                    "  Intensity : " + rom_intensity + "\n" +
                    "Overall: " + getAttraction() + "\n";
        }
    }
}
