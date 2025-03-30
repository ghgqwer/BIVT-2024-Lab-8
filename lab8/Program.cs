﻿using System;
using System.Linq;

namespace Lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.";
            string answer = "Пос! много!т\"х исс!дова\"й уч#ые обнаружили тревожную т#д#цию в вырубке !сов Амазо\"и. Анализ дан$х показал, что основной уча%\"к разруше\"я !сного покрова – человеческая деятельно%ь. За пос!д\"е десяти!тия ро% объема вырубки до%иг критических показате!й. Глав$ми факторами, способ%вующими этому, являются промыш!н$е рубки, производ%во древеси$, расшире\"е сельскохозяй%в#$х угодий и незаконная добыча древеси$. Это приводит к серьез$м экологическим пос!д%виям, таким как потеря биоразнообразия, ухудше\"е климата и угроза вымира\"я многих видов живот$х и ра%е\"й.";
            Purple_3 s = new Purple_3(input1);
            s.Review();
            string output = s.ToString();
            System.Console.WriteLine(output);
            System.Console.WriteLine(output==answer);
        }
    }
    
}

