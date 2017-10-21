using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class pan
    {
        public oil[] Oil;
        private egg[] egg;
        private salt salt;

        public bool ReadyToGo { get { return Check(); } }

        public void init(int count_egg)
        {
            Oil = new oil[20];
            egg = new egg[count_egg];
        }

        public void add_oil(oil o)
        {
            for (int i = 0; i < Oil.Length; i++)
            {
                if (Oil[i] == null)
                {
                    Oil[i] = o;
                    return;
                }
            }
        }

        public void add_salt(salt s)
        {
            salt = s;
        }

        public void add_egg(egg e)
        {
            for (int i = 0; i < egg.Length; i++)
            {
                if (egg[i] == null)
                {
                    egg[i] = e;
                    return;
                }
            }
        }
        private bool Check()
        {
            //if (Oil.Length == 0)
            //{
            //    return false;
            //}

            if (egg.Length == 0)
            {
                return false;
            }

            //for (int i = 0; i < Oil.Length; i++)
            //{
            //    if (Oil[i] == null)
            //    {
            //        return false;
            //    }
            //}

            for (int i = 0; i < egg.Length; i++)
            {
                if (egg[i] == null)
                {
                    return false;
                }
            }

            return true;
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (Oil.Length > 0)
            {
               if (Oil[0].Temperature < 100)
                {
                    for (int i = 0; i < Oil.Length; i++)
                    {
                        Oil[i].GetHead();
                    }
                    bool flag = false;
                    switch (Oil[0].Temperature)
                    {
                        case 20: flag = true; break;
                        case 40: flag = true; break;
                        case 60: flag = true; break;
                        case 80: flag = true; break;
                        case 100: flag = true; break;
                    }
                    if (flag)
                    {
                        for (int i = 0; i < egg.Length; i++)
                        {
                            egg[i].GetHeat();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < egg.Length; i++)
                    {
                        egg[i].GetHeat();
                    }
                }
            }
        }


        public bool is_ready()
        {
			//for (int i = 0; i < Oil.Length; i++)
			//{
			//	if (Oil[i].Temperature < 100)
			//	{
			//		return false;
			//	}
			//}

			for (int i = 0; i < egg.Length; i++)
            {
                if (egg[i].Has_ready < 10)
                {
                    return false;
                }
            }

            return true;
        }

        public egg[] get_egg()
        {
            return egg;
        }

    }
}
