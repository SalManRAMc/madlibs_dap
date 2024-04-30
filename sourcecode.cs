using System;
using WMPLib;

namespace MadlibsApp
{
    abstract class Madlibs
    {
        public virtual string Change(string template, string[] str)
        {
            template = template.Replace("[1] ____________", $"___{str[0]}___");
            template = template.Replace("[2] ____________", $"___{str[1]}___");
            template = template.Replace("[3] ____________", $"___{str[2]}___");
            template = template.Replace("[4] ____________", $"___{str[3]}___");
            template = template.Replace("[5] ____________", $"___{str[4]}___");
            template = template.Replace("[6] ____________", $"___{str[5]}___");
            return template;
        }
        public abstract string Take(int x);
        public abstract void MadTheme();
    }
    class Love : Madlibs
    {
         string[] template = { "Once upon a time, in a [1] ____________ far away, there lived a [2] ____________ named [3] ____________.\n" +
            "One sunny day, while strolling through the [4] ____________, they stumbled upon a [5] ____________." +
            "\r\n\r\nTheir eyes met, and in that moment, they knew they had found their [6] ____________.",
            "In the bustling streets of [1] ____________, amidst the crowd, there stood a [2] ____________ named [3] ____________.\n" +
            "One rainy evening, while seeking shelter in a cozy [4] ____________, they crossed paths with a [5] ____________." +
            "\r\n\r\nTheir laughter echoed in the air, and in that instant, they felt a spark of [6] ____________.",
            "In a quaint village nestled among [1] ____________ hills, lived a [2] ____________ named [3] ____________.\n" +
                "One starry night, while gazing at the shimmering [4] ____________, they encountered a mysterious [5] ____________." +
                "Their conversation flowed like a gentle stream, and in that enchanted moment, they sensed the magic of [6] ____________.",
        "Amidst the chaos of [1] ____________ city life, there resided a [2] ____________ known as [3] ____________.\n" +
                "One chilly morning, while sipping coffee at a bustling [4] ____________, they collided with a [5] ____________." +
                "\r\n\r\nTheir eyes locked, and amidst the hustle and bustle, they felt an undeniable sense of [6] ____________.",
        "In a picturesque [1] ____________ town, there dwelled a [2] ____________ named [3] ____________.\n" +
                "One crisp autumn day, while wandering through a vibrant [4] ____________, they crossed paths with a [5] ____________." +
                "\r\n\r\nTheir laughter filled the air, and amid the fallen leaves, they discovered a shared passion for [6] ____________." };
        public override string Take(int x) 
        {
            return template[x];
        }

        public override void MadTheme()
        {
            WindowsMediaPlayer lovenoise = new WindowsMediaPlayer();
            lovenoise.URL = "SOUND EFFECT LOVE MOMENT.mp3";
            lovenoise.controls.Play();
        }
    }
    class Horror : Madlibs
    {
        string[] template = { "In the dark of night, [1] ____________ entered the ancient manor atop the hill. They sought the truth behind tales of [2] ____________ haunting its halls.Within, the air was heavy with the scent of [3] ____________, and eerie sounds echoed through the corridors." +
                "Clutching their [4] ____________, they ventured forth, determined to uncover the secrets within.Suddenly, a figure emerged, eyes glinting with [5] ____________. " +
                "Paralyzed with fear, they watched as it drew near.Recalling an ancient incantation, they spoke, releasing a burst of [6] ____________ that banished the spirit." +
                "They fled, vowing never to return, but whispers of their encounter lingered, a reminder of the terrors that lurk within the dread manor.",
            "In the heart of [1] ____________, there stood a decrepit mansion, its ancient walls whispering tales of [2] ____________ and despair. Legend had it that [3] ____________ roamed its halls, their anguished cries echoing through the night.\r\n\r\nBrave souls dared to enter, drawn by the promise of [4] ____________ treasures hidden within. " +
                "But as they crossed the threshold, they felt a chill crawl down their spines, as if the very air itself was alive with malevolence." +
                "\r\n\r\nEvery step deeper into the mansion revealed more secrets, more horrors lurking in the shadows. Cobwebs clung to the ceilings like [5] ____________, and the floorboards creaked beneath their weight as if protesting their intrusion." +
                "\r\n\r\nThen, just as they thought they might escape, they heard it—the low, guttural moan of something not quite human. With hearts pounding, they turned to flee, only to find the door sealed shut, trapping them in the grasp of [6] _____________",
            "In the heart of [1] ____________, hidden deep within the dense forest, there lay an ancient altar, its stones weathered by centuries of time. Whispers among the villagers spoke of [2] ____________ rituals performed under the light of the full moon, summoning dark forces from the abyss." +
                "\r\n\r\nCuriosity or perhaps folly led a group of young adventurers to seek out the altar, their minds filled with tales of power and forbidden knowledge. They journeyed through the winding paths, each step bringing them closer to [3] ____________ they could not comprehend." +
                "\r\n\r\nAs they reached the clearing, they felt a palpable sense of dread wash over them, the air thick with the scent of [4] ____________. Yet, undeterred, they pressed on, determined to unravel the mysteries hidden within the ancient stones." +
                "\r\n\r\nWith trembling hands, they began the incantations, their voices trembling as they spoke the words of [5] ____________ that had long been forgotten. But as the ritual reached its climax, they felt a presence stirring in the darkness, something ancient and malevolent awakened by their foolishness." +
                "\r\n\r\nIn a frenzy of fear, they tried to flee, but the forest seemed to twist and turn, leading them deeper into the heart of darkness. And as they disappeared into the shadows, the echoes of their screams mingled with the howling wind, a warning to all who would dare to tamper with the [6] ____________.",
            "In the heart of [1] ____________, shrouded in mist and mystery, stood an abandoned theater, its once-grand stage now a crumbling relic of forgotten dreams. Legend had it that the ghost of a tortured performer, known only as [2] ____________, haunted its halls, forever cursed to relive the final act of their tragic life." +
                "\r\n\r\nWhispers of [3] ____________ filled the air, tales of love betrayed and promises broken, echoing through the empty corridors like a mournful symphony. " +
                "Those who dared to venture inside spoke of strange apparitions and ghostly voices that seemed to call out from the darkness." +
                "\r\n\r\nBut still, there were those drawn to the theater's faded glamour, lured by the promise of uncovering its long-lost secrets. They crept through the shadows, their footsteps echoing like the beat of a distant drum, until they stood upon the stage where [4] ____________ had once performed." +
                "\r\n\r\nAnd as they gazed out into the empty seats, they felt a chill run down their spines, as if the very air itself was heavy with the weight of [5] ____________. In that moment, they knew they were not alone, that the spirit of [6] ____________ watched their every move, forever trapped in a never-ending encore of sorrow.",
            "In the heart of [1] ____________, beneath the shadow of an ancient oak tree, lay a hidden chamber containing a mysterious artifact, its origins lost to the sands of time. Whispers in the village spoke of [2] ____________ that surrounded the object, tales of misfortune befalling all who dared to possess it." +
                "\r\n\r\nDespite the warnings, a bold adventurer set out to uncover the truth behind the artifact, driven by a thirst for knowledge and the promise of untold riches. They journeyed through treacherous terrain, guided only by the whispers of the wind and the faint glow of [3] ____________." +
                "\r\n\r\nFinally, they reached the chamber, its entrance guarded by symbols of [4] ____________. With trembling hands, they reached out to claim the artifact, feeling its power coursing through their veins like a surge of electricity." +
                "\r\n\r\nBut as they lifted it from its resting place, they felt a chill run down their spine, a sense of foreboding that they could not shake. And as they turned to leave, they heard the sound of [5] ____________ echoing through the darkness, a warning of the horrors to come." +
                "\r\n\r\nFor they had awakened a curse that had lain dormant for centuries, a curse that would consume them and all who dared to seek the truth of [6] ____________." };
        public override string Take(int x)
        {
            return template[x];
        }

        public override void MadTheme()
        {
            WindowsMediaPlayer horrornoise = new WindowsMediaPlayer();
            horrornoise.URL = "ROBLOX Music Horror.mp3";
            lovenoise.controls.Play();
        }

    }
    class Happy : Madlibs
    {
        string[] template = { "Once upon a time, there was a [1] ____________ who lived in a [2] ____________.\n" +
                "Every day, they would [3] ____________ with their [4] ____________ and [5] ____________." +
                "\n\nBut one day, something [6] ____________ happened that changed everything.",
            "Once upon a time, in a [1] ____________ far, far away, there lived a [2] ____________ who was always [3] ____________.\n" +
                "Every morning, they would wake up with a [4] ____________ in their heart and a smile on their face. " +
                "\nThey loved to spend their days [5] ____________ and [6] ____________, spreading joy wherever they went.",
            "In the cheerful kingdom of [1] ____________, there dwelled a [2] ____________ named [3] ____________.\n" +
                "Their days were filled with [4] ____________ and [5] ____________, bringing smiles to all who crossed their path.\n" +
                "They were known for their [6] ____________ and contagious laughter, spreading happiness far and wide.\r\n\r\n",
            "In a land of perpetual [1] ____________, there resided a merry [2] ____________ named [3] ____________.\n" +
                "Their heart was a garden of [4] ____________, where laughter bloomed like [5] ____________ and kindness flowed like a gentle [6] ____________.",
            "In the heart of [1] ____________ville, where the streets were paved with [2] ____________ and the sky painted in shades of [3] ____________, lived a jubilant [4] ____________.\n" +
                "Known for their infectious [5] ____________ and boundless [6] ____________,\nthey spread joy to all they encountered, turning ordinary moments into extraordinary memories with their contagious laughter and warm-hearted gestures." };
        public override string Take(int x)
        {
            return template[x];
        }
        public override void MadTheme()
        {
            WindowsMediaPlayer HappyNoise = new WindowsMediaPlayer();
            HappyNoise.URL = "March my man.mp3";
            HappyNoise.controls.Play();
        }

    }
    class Sad : Madlibs
    {
        string[] template = { "Today, I woke up feeling [1] ____________. The sun was hidden behind thick clouds, casting a [2] ____________ gloom over everything. As I walked through the streets, I couldn't shake off this [3] ____________ feeling in my chest. " +
                "It seemed like the whole world was [4] ____________ with me.\n\n" +
                "When I reached home, I found a [5] ____________ letter waiting for me on the table. It was from [6] ____________, and as I read their words, tears streamed down my face.",
            "As I sat alone in the [1] ____________ room, I couldn't help but feel a sense of [2] ____________. The walls seemed to close in on me, suffocating me with their [3] ____________ silence.\n" +
                "Memories of [4] ____________ times flooded my mind, and I couldn't shake off the feeling of [5] ____________ regret." +
                "\n\nOutside, the rain [6] ____________ against the windowpane, mirroring the storm raging within me.",
            "Every [1] ____________ feels like a heavy burden, weighing me down with [2] ____________ sadness. The world around me seems to be painted in shades of [3] ____________, reflecting the emptiness I feel inside.\n" +
                "I try to [4] ____________ a smile, but it's as fragile as glass, easily shattered by the slightest touch." +
                "Memories of [5] ____________ moments haunt me, reminding me of what once was.\n\n" +
                "In the silence of the night, I find myself [6] ____________ for a glimmer of hope.",
            "In the [1] ____________ of night, loneliness wraps around me like a [2] ____________ blanket. Each passing moment feels heavier than the last, burdened with [3] ____________ memories.\n" +
                "The echoes of [4] ____________ conversations resonate in my mind, reminding me of what has been lost.\n\n" +
                "Tears [5] ____________ down my cheeks, leaving a trail of [6] ____________ sadness in their wake.",
            "As I gaze out the [1] ____________ window, a sense of [2] ____________ fills the air. The world outside seems to be veiled in a cloak of [3] ____________ despair.\n" +
                "Memories of [4] ____________ moments replay in my mind like a broken record, each one a painful reminder of what once was.\n" +
                "I try to [5] ____________ the ache in my heart, but it lingers like a persistent shadow.\n\n" +
                "In the silence, I find solace in [6] ____________ thoughts, longing for a distant warmth that seems forever out of reach." };
        public override string Take(int x)
        {
            return template[x];
        }

        public override void MadTheme()
        {
            WindowsMediaPlayer sad = new WindowsMediaPlayer();
            sad.URL = "Resting Grounds.mp3";
            sad.controls.Play();
        }
    }

    class Any : Madlibs
    {
        string[] template = { "Today, I went to the zoo with my [1] ____________. We started off by visiting the [2] ____________. It was fascinating to see all the different species of [3] ____________ from around the world. After that, we headed over to the [4] ____________ enclosure.\n" +
                "We were lucky enough to catch a glimpse of a [5] ____________ playing with its toys. Next, we made our way to the [6] ____________ exhibit." +
                "It was incredible to watch them gracefully swimming in the water.\n\n" +
                "Overall, it was a fantastic day filled with laughter and unforgettable memories.",
            "Last night, I decided to explore the infamous [1] ____________ mansion with my friends. As we stepped inside, we were greeted by a chilling gust of wind. The [2] ____________ echoed with mysterious whispers, sending shivers down our spines. We cautiously made our way through the dimly lit corridors, trying to ignore the eerie creaks of the floorboards beneath our feet." +
                "\r\n\r\nSuddenly, we heard a loud [3] ____________ coming from the old staircase. Our hearts raced as we hesitantly climbed the stairs, our flashlight beams cutting through the darkness. At the top, we stumbled upon a dusty [4] ____________ covered in cobwebs. It seemed to be frozen in time, filled with forgotten treasures and haunting relics." +
                "\r\n\r\nAs we continued to explore, we encountered strange [5] ____________ lurking in the shadows. Each room held its own secrets, and we couldn't shake the feeling of being watched. Finally, we reached the [6] ____________ room, where the ghostly apparition of the mansion's former owner appeared before us." +
                "\r\n\r\nWith a scream, we fled from the haunted mansion, vowing never to return. The echoes of our terror followed us into the night, a reminder of the chilling adventure we had embarked upon.",
            "On a bright [1] ____________ morning, my friends and I decided to embark on an exciting journey. We packed our bags and set off in search of [2] ____________, our spirits high with anticipation. Our first stop was the [3] ____________, where we marveled at the breathtaking views stretching out before us." +
                "\r\n\r\nNext, we ventured into the heart of the [4] ____________, where we encountered majestic [5] ____________ roaming freely. The air was filled with the sounds of nature, and we felt a deep sense of connection to the world around us. We hiked through dense [6] ____________, forging unforgettable memories along the way." +
                "\r\n\r\nAs the sun began to set, we gathered around a campfire, sharing stories and laughter beneath the starry sky. It was a day filled with adventure and camaraderie, a testament to the beauty of exploration.",
            "Deep in the heart of [1] ____________, there lies a hidden treasure waiting to be discovered. Legends speak of a [2] ____________ pirate who buried their riches centuries ago, and my friends and I were determined to find it. Armed with a map and a sense of adventure, we set sail across the [3] ____________, braving stormy seas and treacherous waters." +
                "\r\n\r\nAfter days of searching, we finally arrived at the deserted [4] ____________ island, where the treasure was said to be buried. As we explored the island, we stumbled upon ancient [5] ____________ and mysterious landmarks, each clue bringing us closer to our goal. With each passing moment, the excitement grew, fueling our determination to uncover the secrets of the past." +
                "\r\n\r\nFinally, we reached the spot marked on the map and began to dig. Our hearts pounded with anticipation as we unearthed a chest filled with glittering [6] ____________. We had found the legendary treasure, a testament to our perseverance and the thrill of adventure.",
            "One [1] ____________ afternoon, my friends and I decided to explore the enchanted forest that lay beyond our village. As we entered the forest, we were greeted by a chorus of chirping birds and rustling leaves. The air was filled with the sweet scent of [2] ____________, and we felt a sense of wonder wash over us." +
                "\r\n\r\nWe followed a winding path deeper into the forest, marveling at the towering [3] ____________ and vibrant wildflowers that surrounded us. Suddenly, we stumbled upon a sparkling [4] ____________ nestled among the trees. It was a magical sight, and we couldn't resist stepping inside to explore." +
                "\r\n\r\nInside the glade, we discovered a hidden [5] ____________ guarded by mischievous woodland creatures. They led us on a merry chase through the trees, their laughter echoing through the forest. Eventually, we reached the heart of the grove, where a majestic [6] ____________ stood tall." +
                "\r\n\r\nAs we bid farewell to the magical forest, we knew that we would always cherish the memories of our extraordinary adventure." };
        public override string Take(int x)
        {
            return template[x];
        }

        public override void MadTheme()
        {
            WindowsMediaPlayer chaos = new WindowsMediaPlayer();
            chaos.URL = "Orchestrated Chaos.mp3";
            chaos.controls.Play();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!WELCOME TO MADLIBS: THE APP!!!");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Created by: Salman ElHussini - 212004043, Mohammed Reda - 212001281 , ElHassan Tarek - 211014198");
            Console.WriteLine("--------------------------------------------------------------------------------------------------\n\n\n\n");
            Random random = new Random();
            Love love = new Love();
            Horror horror = new Horror();
            Happy happy = new Happy();
            Sad sad = new Sad();
            Any any = new Any();
            int x = 0;
            while (x==0)
            {
                int y = 0, choice = 0;
                while (y == 0)
                {
                    try
                    {
                        Console.WriteLine("Enter :\n(1) for love madlib" +
                         "\n(2) for horror madlib" +
                         "\n(3) for happy madlib" +
                         "\n(4) for sad madlib" +
                         "\n(5) for any madlib" +
                         "\n(6) for random madlib" +
                         "\n(7)[TO EXIT]\n");
                        choice = int.Parse(Console.ReadLine());
                        if (choice >= 1 && choice <= 7)
                        { y = 1; }
                        else 
                        {
                            Console.WriteLine("\n(Enter numbers from 1 to 7 only please!)\n");
                            y = 0; 
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("\n(Enter only numbers please!)\n");
                        y = 0;
                    }
                }
                if (choice == 7)
                { x = 1; }
                else
                {
                    if (choice == 6)
                    {   
                        choice = random.Next(1, 6);
                    } 
                    string k="";
                    switch(choice) 
                    {
                        case 1: 
                            Console.WriteLine("\n-------\n!LOVE!\n-------"); k = love.Take(random.Next(0, 5));
                            love.MadTheme();
                            break;
                        case 2: 
                            Console.WriteLine("\n-------\n!HORROR!\n--------"); k = horror.Take(random.Next(0, 5));
                            horror.MadTheme();
                            break;
                        case 3: 
                            Console.WriteLine("\n-------\n!HAPPY!\n--------"); k = happy.Take(random.Next(0, 5)); 
                            happy.MadTheme();
                            break;
                        case 4: Console.WriteLine("\n-------\n!SAD!\n------"); k = sad.Take(random.Next(0, 5));
                            sad.MadTheme();
                            break;                            
                        case 5: Console.WriteLine("\n-------\n!ANY!\n------"); k = any.Take(random.Next(0, 5)); 
                            any.MadTheme();
                            break;
                    }
                    Console.WriteLine( "\n" + k + "\n\n\n\n");
                    string[] str = new string[6];
                    Console.WriteLine("Enter first word : ");
                    str[0] = Console.ReadLine();
                    str[0] = str[0].ToLower();
                    Console.WriteLine("Enter second word : ");
                    str[1] = Console.ReadLine();
                    str[1] = str[1].ToLower();
                    Console.WriteLine("Enter third word : ");
                    str[2] = Console.ReadLine();
                    str[2] = str[2].ToLower();
                    Console.WriteLine("Enter fourth word : ");
                    str[3] = Console.ReadLine();
                    str[3] = str[3].ToLower();
                    Console.WriteLine("Enter fifth word : ");
                    str[4] = Console.ReadLine();
                    str[4] = str[4].ToLower();
                    Console.WriteLine("Enter sixth word : ");
                    str[5] = Console.ReadLine();
                    str[5] = str[5].ToLower();
                    switch (choice)
                    {
                        case 1: k = love.Change( k , str ); break;
                        case 2: k = horror.Change( k , str ); break;
                        case 3: k = happy.Change( k , str ); break;
                        case 4: k = sad.Change( k , str ); break;
                        case 5: k = any.Change( k , str ); break;
                    }
                    
                    Console.WriteLine("\n---------------------------------------------------------------------------------------\n" 
                        + k +
                        "\n---------------------------------------------------------------------------------------\n");
                    int playagain = 0;
                    while (playagain == 0)
                    {
                        Console.WriteLine("Do you want to play again  [Y/N]??");
                        string l = Console.ReadLine();
                        l = l.ToUpper();
                        switch(l) 
                        {
                            case "Y": x = 0;playagain = 1; break;
                            case "N": x = 1;playagain = 1; break;
                            default: Console.WriteLine("Improper answer!!!\nChoose [Y/N]");playagain = 0; break;
                        }
                        Console.WriteLine("\n");
                    }
                }

            }
            Console.WriteLine("\n(THANKS FOR PLAYING OUR GAME!!)");
            Console.ReadKey();
        }
    }
}
