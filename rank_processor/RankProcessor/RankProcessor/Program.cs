using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RankProcessor {
    class Program {
        static void Main( string[] args ) {
            if ( args.Length != 1 ) {
                Console.WriteLine( "Invalid number of arguments" );
                return;
            }
            string filepath = args[0];

            string[] lines = new string[100];
            int index = 0;
            using ( StreamReader sr = new StreamReader( filepath ) ) {
                sr.ReadLine();
                while ( !sr.EndOfStream ) {
                    lines[index] = sr.ReadLine();
                    index++;
                }
            }

            for ( int j = 0; j < index; j++ )
                for ( int i = 0; i < index - 1; i++ ) {
                    string currentLine = lines[i];
                    string nextLine = lines[i + 1];
                    string temp;

                    if ( int.Parse( currentLine.Split( ',' )[0] ) > int.Parse( nextLine.Split( ',' )[0] ) ) {
                        temp = currentLine;
                        lines[i] = nextLine;
                        lines[i + 1] = temp;
                    }
                }

            using ( StreamWriter sw = new StreamWriter( filepath + ".output.txt" ) )
                for ( int i = 0; i < index + 1; i++ ) {
                    sw.WriteLine( lines[i] );
                }
        }
    }
}
