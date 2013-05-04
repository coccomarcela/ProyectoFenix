using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NCalc;

namespace PracticosLogMat.Entities
{

    public enum OpExp1
    {
        sum=0,
        prod=1,
        simple=2
    }

    public enum igualdad
    {
//       =
        igual=0,
//>
        mayorque=1,
//<
        menorque=2,
//>=
        mayorigualque=3,
//<= 
        menorigualque=4
    }


    class Class_UnII_TP4_EJ_A2C
    {

        #region Properties

        private OpExp1 _opExp=OpExp1.prod ;

        public OpExp1 opExp
        {
            get { return _opExp; }
            set { _opExp = value; }
        }

        private igualdad _igu=igualdad.igual  ;

        public igualdad Iguales
        {
            get { return _igu; }
            set { _igu = value; }
        }

        private string _iguString="=";

        public string IguString
        {
            get { return _iguString; }
            set { 
                _iguString = value;

                switch (_iguString)
                {
                    case "=":
                        _igu = igualdad.igual ;
                        break;
                    case ">":
                        _igu = igualdad.mayorque;
                       break;
                    case "<":
                        _igu = igualdad.menorque  ;
                        break;
                    case ">=":
                        _igu = igualdad.mayorigualque;
                        break;
                    case "<=":
                        _igu = igualdad.menorigualque;
                        break;
                    default:
                        break;
                }


////<
//        menorque=2,
////>=
//        mayorigualque=3,
////<= 
//        menorigualque=4
            }
        }

        

        private string _expresion1;

        public string Expresion1
        {
            get { return _expresion1; }
            set { _expresion1 = value; }
        }

        private string _expresion2;

        public string Expresion2
        {
            get { return _expresion2; }
            set { _expresion2 = value; }
        }


        private string _Induccion_exp1_N1 = "1) Para n=1  con K variando de 1 a N de la proposicion --->  ";

        public string Induccion_exp1_N1
        {
            get { return _Induccion_exp1_N1; }
            set { _Induccion_exp1_N1 = value; }
        }


        private string _Induccion_Tesis = "2) TESIS :Para n=h  con K variando de 1 a N de la proposicion --->  ";

        public string Induccion_Tesis
        {
            get { return _Induccion_Tesis ; }
            set { _Induccion_Tesis  = value; }

        }


        private string _Induccion_Hipotesis = "2) Hipotesis :Para n=h+1  con K variando de 1 a N de la proposicion --->  ";

        public string Induccion_Hipotesis
        {
            get { return _Induccion_Hipotesis; }
            set { _Induccion_Hipotesis = value; }

        }



        private Decimal _Res_Exp1_A;

        public Decimal Res_Exp1_A
        {
            get { return _Res_Exp1_A; }
            set { _Res_Exp1_A = value; }
        }

        private String _Res_Exp1_A_str;

        public String Res_Exp1_A_str
        {
            get { return _Res_Exp1_A_str; }
            set { _Res_Exp1_A_str = value; }
        }

        private String _Res_Exp2_A_str;

        public String Res_Exp2_A_str
        {
            get { return _Res_Exp2_A_str; }
            set { _Res_Exp2_A_str = value; }
        }

        private Decimal _Res_Exp1_B;

        public Decimal Res_Exp1_B
        {
            get { return _Res_Exp1_B; }
            set { _Res_Exp1_B = value; }
        }

        private string _Res_Exp1_B_str;

        public string Res_Exp1_B_str
        {
            get { return _Res_Exp1_B_str; }
            set { _Res_Exp1_B_str = value; }
        }


        private Decimal _Res_Exp2_A;

        public Decimal Res_Exp2_A
        {
            get { return _Res_Exp2_A; }
            set { _Res_Exp2_A = value; }
        }

        private Decimal _Res_Exp2_B;

        public Decimal Res_Exp2_B
        {
            get { return _Res_Exp2_B; }
            set { _Res_Exp2_B = value; }
        }

        private string _Res_Exp2_B_str;

        public string Res_Exp2_B_str
        {
            get { return _Res_Exp2_B_str; }
            set { _Res_Exp2_B_str = value; }
        }
            
            

        #endregion


        public Class_UnII_TP4_EJ_A2C()
        {
        }


        public void Asignar(
            string pExpresion1,
            string pIgualdad,
            string pExpresion2)          
            
          
        {
          
            this.Expresion1  = pExpresion1;
            this.IguString  = pIgualdad;
            this.Expresion2  = pExpresion2;

            Inicializar();
        }

            private void Inicializar()
        {
            switch (opExp)
            {
                case OpExp1.sum:
                    asignarInduccion_Sumatoria();
                    asignarInduccion_Tesis_Sumatoria();
                    asignarInduccion_Hipotesis_Sumatoria();
                    
                    break;
                case OpExp1.prod:
                    asignarInduccion_Productoria();
                    asignarInduccion_Tesis_Productoria();
                    asignarInduccion_Hipotesis_Productoria();
                    break;
              
                default:
                    throw new ArgumentException("Funcion No Implementada");
                    
            }

           

        }


            private void asignarInduccion_Sumatoria()
            {
                Induccion_exp1_N1 = "1) Para n=1  con K variando de 1 a N de la proposicion --->  ";
                this.Induccion_exp1_N1 += "Σ " + Expresion1 + " " + IguString + " " + Expresion2 + "\n\n";
                this.Induccion_exp1_N1 += "Σ " + Expresion1.Replace("[k]", "1") + " " + IguString + " " + Expresion2.Replace("[n]", "1") + "\n\n";
                this.Induccion_exp1_N1 += "------: \n\n";

                Expression o = new Expression(Expresion1.Replace("[k]", "1"));
                string s1 = o.Evaluate().ToString();
                Expression o1 = new Expression(Expresion2.Replace("[n]", "1"));
                string s2 = o1.Evaluate().ToString();

                this.Induccion_exp1_N1 += "Σ " + Expresion1 + " = " + Expresion1.Replace("[k]", "1") + " = " + s1.ToString() + "\n\n";
                this.Induccion_exp1_N1 +=  Expresion2 + " = " + Expresion2.Replace("[n]", "1") + " = " + s2 + "\n\n";

            }

            private void asignarInduccion_Productoria()
        {
            Induccion_exp1_N1 = "1) Para n=1  con K variando de 1 a N de la proposicion --->  ";
            this.Induccion_exp1_N1 += "π " + Expresion1 + " " + IguString + " " + Expresion2 + "\n\n";
            this.Induccion_exp1_N1 += "π " + Expresion1.Replace("[k]", "1") + " " + IguString + " " + Expresion2.Replace("[n]", "1") + "\n\n";
            this.Induccion_exp1_N1 += "---------: \n\n";
            Expression ox = new Expression(Expresion1.Replace("[k]", "1"));
            string sx1 = ox.Evaluate().ToString();
            Expression ox1 = new Expression(Expresion2.Replace("[n]", "1"));
            string sx2 = ox1.Evaluate().ToString();

            this.Induccion_exp1_N1 += "π " + Expresion1 + " = " + Expresion1.Replace("[k]", "1") + " = " + sx1.ToString() + "\n\n";
            this.Induccion_exp1_N1 += Expresion2 + " = " + Expresion2.Replace("[n]", "1") + " = " + sx2 + "\n\n";
        }

             private void asignarInduccion_Tesis_Sumatoria()
 {
     Induccion_Tesis = "2) TESIS :Para n=h  con K variando de 1 a N de la proposicion --->  ";
     this.Induccion_Tesis += "Σ " + Expresion1 + " " + IguString + " " + Expresion2 + "\n\n";
     this.Induccion_Tesis += "Σ " + Expresion1.Replace("[k]", "h") + " " + IguString + " " + Expresion2.Replace("[n]", "h") + "\n\n";
     this.Induccion_Tesis += "------: \n\n";

     this.Induccion_Tesis += "Σ " + Expresion1 + " = ";
     this.Induccion_Tesis += Expresion1.Replace("[k]", "1") + " + ";
     this.Induccion_Tesis += Expresion1.Replace("[k]", "2") + " + ";
     this.Induccion_Tesis += Expresion1.Replace("[k]", "3") + " + ";
     this.Induccion_Tesis += Expresion1.Replace("[k]", "4") + " + ";
     this.Induccion_Tesis += "...+ ";
     this.Induccion_Tesis += Expresion1.Replace("[k]", "h");

     Expression o = new Expression(Expresion1);


     this.Induccion_Tesis += " = ";
     o.Parameters["k"] = 1;
     this.Induccion_Tesis += o.Evaluate().ToString() + " + ";
     o.Parameters["k"] = 2;
     this.Induccion_Tesis += o.Evaluate().ToString() + " + ";
     o.Parameters["k"] = 3;
     this.Induccion_Tesis += o.Evaluate().ToString() + " + ";
     o.Parameters["k"] = 4;
     this.Induccion_Tesis += o.Evaluate().ToString() + " + ";
     this.Induccion_Tesis += "...+ ";
     this.Induccion_Tesis += Expresion1.Replace("[k]", "h");

     this.Induccion_Tesis += "\n\n";

     this.Induccion_Tesis += Expresion2 + " = " + Expresion2.Replace("[n]", "h") + "\n\n";

    

 }

            private void asignarInduccion_Tesis_Productoria()
        {
            Induccion_Tesis = "2) TESIS :Para n=h  con K variando de 1 a N de la proposicion --->  ";
            this.Induccion_Tesis += "π " + Expresion1 + " " + IguString + " " + Expresion2 + "\n\n";
            this.Induccion_Tesis += "π " + Expresion1 + " " + IguString + " " + Expresion2.Replace("[n]", "h") + "\n\n";
            this.Induccion_Tesis += "------: \n\n";

            this.Induccion_Tesis += "π " + Expresion1 + " = ";
            this.Induccion_Tesis += Expresion1.Replace("[k]","1") + " * ";
            this.Induccion_Tesis += Expresion1.Replace("[k]", "2") + " * ";
            this.Induccion_Tesis += Expresion1.Replace("[k]", "3") + " * ";
            this.Induccion_Tesis += Expresion1.Replace("[k]", "4") + " * ";
            this.Induccion_Tesis += "...* ";
            this.Induccion_Tesis += Expresion1.Replace("[k]", "h");

            Expression o = new Expression(Expresion1);
            
            
            this.Induccion_Tesis += " = ";
            o.Parameters["k"] = 1;
            this.Induccion_Tesis += o.Evaluate().ToString() +" * ";
            o.Parameters["k"] = 2;
            this.Induccion_Tesis += o.Evaluate().ToString() + " * ";
            o.Parameters["k"] = 3;
            this.Induccion_Tesis += o.Evaluate().ToString() + " * ";
            o.Parameters["k"] = 4;
            this.Induccion_Tesis += o.Evaluate().ToString() + " * ";
            this.Induccion_Tesis += "...* ";
            this.Induccion_Tesis += Expresion1.Replace("[k]", "h");

            this.Induccion_Tesis +="\n\n";

            this.Induccion_Tesis += Expresion2 + " = " + Expresion2.Replace("[n]", "h") + "\n\n";
        }

            private void asignarInduccion_Hipotesis_Productoria()
            {
                Induccion_Hipotesis = "3) Hipotesis :Para n=h+1  con K variando de 1 a N de la proposicion --->  ";
                this.Induccion_Hipotesis += "π " + Expresion1 + " " + IguString + " " + Expresion2 + "\n\n";
                this.Induccion_Hipotesis += "π " + Expresion1 + " " + IguString + " " + Expresion2.Replace("[n]", "(h+1)") + "\n\n";
                this.Induccion_Hipotesis += "------: \n\n";

                this.Induccion_Hipotesis += "π " + Expresion1 + " = ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "1") + " * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "2") + " * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "3") + " * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "4") + " * ";
                this.Induccion_Hipotesis += "...* ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h-1)") + " * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "h") + " * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h+1)");

                Expression o = new Expression(Expresion1);


                this.Induccion_Hipotesis += " = [ ";
                o.Parameters["k"] = 1;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " * ";
                o.Parameters["k"] = 2;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " * ";
                o.Parameters["k"] = 3;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " * ";
                o.Parameters["k"] = 4;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " * ";
                this.Induccion_Hipotesis += "...* ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h-1)") + " * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "h") + " ] * ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h+1)");

                this.Induccion_Hipotesis += "\n\n";
                this.Induccion_Hipotesis += "-->Por tesis Para n=h se verifica π " + Expresion1 + " " + IguString + " " + Expresion2.Replace("[n]","h") + "\n";
                this.Induccion_Hipotesis += "-->Reemplazo termino[] por --> " + Expresion2.Replace("[n]", "h") + "\n";
                this.Induccion_Hipotesis += "π " + Expresion1 + " = ";
                this.Induccion_Hipotesis += Expresion2.Replace("[n]", "h") + " * " + Expresion1.Replace("[k]", "(h+1)") ;
                this.Induccion_Hipotesis += " " + IguString + " " + Expresion2.Replace("[n]", "(h+1)") + "\n\n";
            }

            private void asignarInduccion_Hipotesis_Sumatoria()
            {
                Induccion_Hipotesis = "3) Hipotesis :Para n=h+1  con K variando de 1 a N de la proposicion --->  ";
                this.Induccion_Hipotesis += "Σ " + Expresion1 + " " + IguString + " " + Expresion2 + "\n\n";
                this.Induccion_Hipotesis += "Σ " + Expresion1 + " " + IguString + " " + Expresion2.Replace("[n]", "(h+1)") + "\n\n";
                this.Induccion_Hipotesis += "------: \n\n";

                this.Induccion_Hipotesis += "Σ " + Expresion1 + " = ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "1") + " + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "2") + " + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "3") + " + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "4") + " + ";
                this.Induccion_Hipotesis += "...+ ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h-1)") + " + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "h") + " + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h+1)");

                Expression o = new Expression(Expresion1);


                this.Induccion_Hipotesis += " = [ ";
                o.Parameters["k"] = 1;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " + ";
                o.Parameters["k"] = 2;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " + ";
                o.Parameters["k"] = 3;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " + ";
                o.Parameters["k"] = 4;
                this.Induccion_Hipotesis += o.Evaluate().ToString() + " + ";
                this.Induccion_Hipotesis += "...+ ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h-1)") + " + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "h") + " ] + ";
                this.Induccion_Hipotesis += Expresion1.Replace("[k]", "(h+1)");

                this.Induccion_Hipotesis += "\n\n";
                this.Induccion_Hipotesis += "-->Por tesis Para n=h se verifica Σ " + Expresion1 + " " + IguString + " " + Expresion2.Replace("[n]", "h") + "\n";
                this.Induccion_Hipotesis += "-->Reemplazo termino[] por --> " + Expresion2.Replace("[n]", "h") + "\n";
                this.Induccion_Hipotesis += "Σ " + Expresion1 + " = ";
                this.Induccion_Hipotesis += Expresion2.Replace("[n]", "h") + " + " + Expresion1.Replace("[k]", "(h+1)");
                this.Induccion_Hipotesis += " " + IguString + " " + Expresion2.Replace("[n]", "(h+1)") + "\n\n";
            }

         

           

            
            public void CalcularParaN(decimal  n)
            {

                switch (opExp)
                {
                    case OpExp1.sum:
                        Calcular_Sumatoria_ParaN(n);
                        break;
                    case OpExp1.prod:
                        Calcular_Productoria_ParaN(n);
                        break;

                    default:
                        throw new ArgumentException("Funcion No Implementada");

                }



              




            }



            private void Calcular_Productoria_ParaN(decimal n)
            {
                //Incializo Valores
                Res_Exp1_A = 1;
                Res_Exp2_A = 1;

                Expression o = new Expression(Expresion1);
                string r = "";

                //Calculo Para N PARA {A}
                for (int i = 1; i <= n; i++)
                {
                    o.Parameters["k"] = i;
                    r = o.Evaluate().ToString();
                    Res_Exp1_A = Res_Exp1_A * decimal.Parse(r);

                }
                //Calculo Para N+1 PARA {A}
                o.Parameters["k"] = n+1;
                r = o.Evaluate().ToString();
                Res_Exp2_A = Res_Exp1_A * decimal.Parse(r);

                //Txt Para Mostrar
                Res_Exp1_A_str = "{A para n= " + n.ToString() + " } π" + Expresion1 + " = " + Res_Exp1_A.ToString();
                Res_Exp2_A_str = "{A para n= " + (n + 1).ToString() + " } π" + Expresion1 + " = " + Res_Exp2_A.ToString();

                //=====================
                //Calculo  {B}
                //=====================

                Expression o1 = new Expression(Expresion2);
                //Para N PARA
                o1.Parameters["n"] = n ;                          
                r = o1.Evaluate().ToString();
                Res_Exp1_B = decimal.Parse(r);
                //Para N+1 PARA
                o1.Parameters["n"] = n+1;
                r = o1.Evaluate().ToString();
                Res_Exp2_B = decimal.Parse(r);

                //Txt Para Mostrar
                Res_Exp1_B_str = "{B para n= " + n.ToString() + " } " + Expresion2 + " = " + Res_Exp1_B.ToString();
                Res_Exp2_B_str = "{B para n= " + (n+1).ToString() + " } " + Expresion2 + " = " + Res_Exp2_B.ToString();
            }

            private void Calcular_Sumatoria_ParaN(decimal n)
            {
                //Incializo Valores 
                Res_Exp1_A = 0;
                Res_Exp2_A = 0;

                Expression o = new Expression(Expresion1);
                string r = "";

                //Calculo Para N PARA {A}
                for (int i = 1; i <= n; i++)
                {
                    o.Parameters["k"] = i;
                    r = o.Evaluate().ToString();
                    Res_Exp1_A = Res_Exp1_A + decimal.Parse(r);

                }
                //Calculo Para N+1 PARA {A}
                o.Parameters["k"] = n + 1;
                r = o.Evaluate().ToString();
                Res_Exp2_A = Res_Exp1_A + decimal.Parse(r);

                //Txt Para Mostrar
                Res_Exp1_A_str = "{A para n= " + n.ToString() + " } Σ" + Expresion1 + " = " + Res_Exp1_A.ToString();
                Res_Exp2_A_str = "{A para n= " + (n + 1).ToString() + " } Σ" + Expresion1 + " = " + Res_Exp2_A.ToString();

                //=====================
                //Calculo  {B}
                //=====================

                Expression o1 = new Expression(Expresion2);
                //Para N PARA
                o1.Parameters["n"] = n;
                r = o1.Evaluate().ToString();
                Res_Exp1_B = decimal.Parse(r);
                //Para N+1 PARA
                o1.Parameters["n"] = n + 1;
                r = o1.Evaluate().ToString();
                Res_Exp2_B = decimal.Parse(r);

                //Txt Para Mostrar
                Res_Exp1_B_str = "{B para n= " + n.ToString() + " } " + Expresion2 + " = " + Res_Exp1_B.ToString();
                Res_Exp2_B_str = "{B para n= " + (n + 1).ToString() + " } " + Expresion2 + " = " + Res_Exp2_B.ToString();
            }



    }
}
