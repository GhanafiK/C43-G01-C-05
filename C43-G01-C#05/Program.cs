namespace C43_G01_C_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting (Boxing - UnBoxing)

            #region Boxing [Safe Casting]
            //object obj = new object();
            //int x = 1;
            //obj = x;// Boxing casting ==> convert from value type to reference type 
            #endregion

            #region unBoxing [unsafe casting]
            //object obj2=new object();
            //obj2 = 10;
            //int y = (int)obj2;// unBoxing casting ==> convert from reference type to value type
            #endregion


            #endregion

            #region Nullable (value type - reference type)

            #region nullable value type
            ////value type does n't accept null
            //int x = 22;// only accept int numbers
            //int? xx = null;// accept int numbers & null
            //int y;
            //if (xx != null)
            //{
            //    y = (int)xx;// casting
            //}
            //else
            //{
            //    y = 0;
            //}

            ////or
            ////we use second method because it does n't has casting

            //if (xx.HasValue)
            //{
            //    y = xx.Value;
            //}
            //else
            //{
            //    y = 0;
            //}
            #endregion

            #region nullable reference type
            ////reference type accept null but we use nullable with it to remove warning
            //string name = null;//has ==> warning that name can be null
            //string? name1 = null;//nullable ==> no warning ==> use it
            //string name3 = null!;// null forgiveness operator (!) ==> no warning
            #endregion

            #endregion
        }
    }
}
