using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sayim
{
    public class Uoms
    {
        private ArrayList uomList;
        private ArrayList enabledUomList;

        public Uoms()
        {
            uomList = new ArrayList();
            add("ST", "ADT");
            add("KG", "KG");
            add("KI", "KL");
            add("PAL", "PAL");
            add("TOR", "TOR");

            enabledUomList = new ArrayList();
        }

        public void add(string Internal, string External)
        {
            Uom u = new Uom(Internal, External);
            uomList.Add(u);
        }

        public Uom defaultEnabledUom
        {
            get
            {
                return (Uom)enabledUomList[0];
            }
        }

        public Uom getTargetUom(string Barkod)
        {
            int n = Barkod.IndexOf("-");

            if (n >= 0)
            {
                return (Barkod.Substring(n + 1, 1) == "P") ? getUomByInternalCode("PAL") : getUomByInternalCode("KI");
            }
            else
            {
                return (Barkod.Substring(0, 1) == "2") ? getUomByInternalCode("PAL") : getUomByInternalCode("KI");
            }
        }

        public void addEnabledUom(string Internal)
        {
            Uom u = getUomByInternalCode(Internal);
            enabledUomList.Add(u);
        }

        public void clearEnabledUoms()
        {
            enabledUomList = new ArrayList();
        }

        public bool manuelInputEnabled
        {
            get
            {
                return (enabledUomList.Count > 1);
            }
        }

        public bool isInputValid(string External)
        {
            try
            {
                Uom u = getUomByExternalCode(External);

                for (int n = 0; n < enabledUomList.Count; n++)
                {
                    Uom u2 = (Uom)enabledUomList[n];
                    if (u.intCode == u2.intCode) return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public Uom getUomByInternalCode(string Internal)
        {
            for (int n = 0; n < uomList.Count; n++)
            {
                Uom u = (Uom)uomList[n];
                if (u.intCode.ToUpper() == Internal.ToUpper()) return u;
            }

            throw new Exception(Internal + " olcu birimi gecerli degil");
        }

        public string internalToExternal(string Internal)
        {
            return getUomByInternalCode(Internal).extCode;
        }

        public Uom getUomByExternalCode(string External)
        {
            for (int n = 0; n < uomList.Count; n++)
            {
                Uom u = (Uom)uomList[n];
                if (u.extCode.ToUpper() == External.ToUpper()) return u;
            }

            throw new Exception(External + " olcu birimi gecerli degil");
        }

        public string externalToInternal(string External)
        {
            return getUomByExternalCode(External).intCode;
        }
    }
}
