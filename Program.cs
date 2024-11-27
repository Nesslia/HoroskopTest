Console.ForegroundColor = ConsoleColor.Green;

string sternzeichen = String.Empty;
bool quest = false;
bool reset = false;
do
{
    do
    {
        quest = false;
        Console.WriteLine("Bitte gebe dein Sternzeichen ein:");
        sternzeichen = Console.ReadLine();  
        Console.WriteLine($"Nach ihren angeben ist ihr Sternzeichen {sternzeichen}. \n Ist diese angabe korrekt (y/n)");
        string korrekt = Console.ReadLine();
        switch (korrekt)
        {
            case "y":
                break;

            case "n":
                quest = true;
                break;

            default:
                Console.WriteLine("Keine gültige eingabe wir beginnen von vorne!");
                quest = true;
                break;
        }
    } while (quest == true);



    Random zufall = new Random();
    int zahl = zufall.Next(1, 11);  //Zahlen 1 bis 10

    switch (zahl)
    {
        case 1:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Diese Woche könnte Ihnen neue Möglichkeiten bieten, die Ihre Kreativität anregen und Ihre Perspektive erweitern");
            break;

        case 2:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Achten Sie auf Ihre zwischenmenschlichen Beziehungen; offene Kommunikation wird entscheidend sein, um Missverständnisse zu vermeiden.");
            break;

        case 3:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Im beruflichen Bereich könnten sich unerwartete Chancen ergeben, die Ihr Engagement und Ihre Fähigkeiten auf die Probe stellen.");
            break;

        case 4:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Es ist ratsam, Ihre Ausgaben im Auge zu behalten und kluge finanzielle Entscheidungen zu treffen, um zukünftige Stabilität zu gewährleisten.");
            break;

        case 5:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Nehmen Sie sich Zeit für sich selbst und achten Sie auf Ihr körperliches und emotionales Wohlbefinden; kleine Veränderungen können große Auswirkungen haben.");
            break;

        case 6:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Nutzen Sie diese Zeit für Selbstreflexion; das Verständnis Ihrer eigenen Bedürfnisse wird Ihnen helfen, klarere Ziele zu setzen.");
            break;

        case 7:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Seien Sie offen für neue Erfahrungen und Begegnungen; sie könnten wertvolle Lektionen und inspirierende Perspektiven mit sich bringen.");
            break;

        case 8:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Überdenken Sie Ihre kurz- und langfristigen Ziele; es könnte an der Zeit sein, Prioritäten neu zu ordnen oder neue Wege einzuschlagen.");
            break;

        case 9:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Hören Sie auf Ihr Bauchgefühl, besonders wenn es um wichtige Entscheidungen geht; Ihre Intuition kann Ihnen wertvolle Hinweise geben.");
            break;

        case 10:
            Console.WriteLine($"Zu deinem Sternzeichen {sternzeichen} gibt es folgendes Horoskop: \n Halten Sie eine positive Einstellung bei Herausforderungen aufrecht; Ihr Optimismus wird Ihnen helfen, Schwierigkeiten leichter zu überwinden.");
            break;
    }

    Console.WriteLine("Wollen sie es Widerholen? (y/n)");
    string wiederholen = Console.ReadLine();
    switch (wiederholen)
    {
        case "y":
            reset = true;
            break;

        case "n":
            reset = false;
            break;

        default:
            Console.WriteLine("Ungültiger wert, Programm wird Beendet!");
            reset = false;
            break;
    }
} while (reset == true);