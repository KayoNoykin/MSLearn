Random random = new Random();
int luck = random.Next(100);

tellFortune(luck);
tellFortune(20);
tellFortune(50);
tellFortune(80);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// Console.WriteLine("A fortune teller whispers the following words:");
// string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
// for (int i = 0; i < 4; i++) 
// {
//     Console.Write($"{text[i]} {fortune[i]} ");
// }

void tellFortune(int luck)
{
    string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
    string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
    string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
    string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

    Console.WriteLine("A fortune teller whispers the following words:");
    for (int i = 0; i < 4; i++)
    {
        if (luck > 75)
        {
            Console.Write($"{text[i]} {good[i]} ");
        }
        else if (luck < 25)
        {
            Console.Write($"{text[i]} {bad[i]} ");
        }
        else
        {
            Console.Write($"{text[i]} {neutral[i]} ");
        }
    }
}