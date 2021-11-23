using System;


namespace TriangleTypeChecker
{
    class Triangle
    {
        enum TriangleType
        {
            Equilateral, // Равносторонний.
            Scalene, // Неравносторонний.
            isosceles , // Равнобедренный.
            RightAngle , // Прямоугольный.
            ObtuseAngle , // Тупоугольный.
            AcuteAngle  // Остроугольный.
        }
        /*Поля класса*/
        private double TriangleFirstSide;
        private double TriangleSecondSide;
        private double TriangleThirdSide;
        /*Конструктор*/
        public void TriangleConstructor(double trianglefirstinput, double trianglesecondinput, double trianglethirdinput)
        {
            TriangleFirstSide = trianglefirstinput;
            TriangleSecondSide = trianglesecondinput;
            TriangleThirdSide = trianglethirdinput;

        }
        /*Метод для определения типа треугольникa*/
        public string TriangleTypeByLength()
        {
            if ((TriangleFirstSide + TriangleSecondSide) > (TriangleThirdSide) && (TriangleFirstSide + TriangleThirdSide) > (TriangleSecondSide) && (TriangleSecondSide + TriangleThirdSide) > (TriangleFirstSide))
            {
                if ((TriangleFirstSide != TriangleSecondSide) && (TriangleFirstSide != TriangleThirdSide) && (TriangleSecondSide != TriangleThirdSide))
                {
                    if ((Math.Pow(TriangleFirstSide, 2.0) + Math.Pow(TriangleSecondSide, 2.0)) == (Math.Pow(TriangleThirdSide, 2.0)))
                    {
                        return nameof(TriangleType.RightAngle) + " " + nameof(TriangleType.Scalene);
                    }
                    else
                    {
                        if ((Math.Pow(TriangleFirstSide, 2.0) + Math.Pow(TriangleSecondSide, 2.0)) > (Math.Pow(TriangleThirdSide, 2.0)))
                        {
                            return nameof(TriangleType.ObtuseAngle) + " " + nameof(TriangleType.Scalene);
                        }
                        else
                        {
                            if (((Math.Pow(TriangleFirstSide, 2.0) + Math.Pow(TriangleSecondSide, 2.0)) < (Math.Pow(TriangleThirdSide, 2.0))))
                            {
                                return nameof(TriangleType.AcuteAngle) + " " + nameof(TriangleType.Scalene);
                            }
                            else
                            {
                                return nameof(TriangleType.Scalene);
                            }
                        }
                    }
                }
                else
                {
                    if (((TriangleFirstSide == TriangleSecondSide) && (TriangleSecondSide == TriangleThirdSide)))
                    {
                        return nameof(TriangleType.Equilateral);
                    }
                    else
                    {
                        if (((TriangleFirstSide == TriangleSecondSide) || (TriangleFirstSide == TriangleThirdSide) || (TriangleSecondSide == TriangleThirdSide)))
                        {
                            if ((Math.Pow(TriangleFirstSide, 2.0) + Math.Pow(TriangleSecondSide, 2.0)) > (Math.Pow(TriangleThirdSide, 2.0)))
                            {
                                return nameof(TriangleType.ObtuseAngle) + " " + nameof(TriangleType.isosceles);
                            }
                            else
                            {
                                if (((Math.Pow(TriangleFirstSide, 2.0) + Math.Pow(TriangleSecondSide, 2.0)) < (Math.Pow(TriangleThirdSide, 2.0))))
                                {
                                    return nameof(TriangleType.AcuteAngle) + " " + nameof(TriangleType.isosceles);
                                }
                                else
                                {
                                    return nameof(TriangleType.isosceles);
                                }
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }

                }
            }
            else
            {
                return "This type of triangle is impossible";
            }
        }

    }
}
