    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    namespace homework1
    {
        public class check
        {
            public static string check_w(int a, int b)
            {
                string s;
                if (a == 1 & b == 3)
                {
                    s = "내가 승";

                }
                else if (a == 3 & b == 1)
                {
                    s = "내가 패";

                }
                else if (a > b)
                {
                    s = "내가 승";

                }
                else if (a < b)
                {
                    s = "내가 패";

                }
                else
                {
                    s = "서로 비김";

                }
                return s;
            }
      

        }

    }