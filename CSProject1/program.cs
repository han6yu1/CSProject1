internal class Program
{
    static void Main(string[] args)
    {
        var abc = 3;

        // ÇÑÁÙÁÖ¼®
        /* ¿©·¯ÁÙ ÁÖ¼® */
        /*** XML ÁÖ¼® ***/

        // #1 12-3. ±âº» ÀÚ·áÇü
        Console.WriteLine(52 + 4 - 1);
        // »çÄ¢¿¬»êÀÚ = »ê¼ú ¿¬»ê = Arithmetic Operator
        // + - * / %

        // ½Ç¼ö(Real Number)
        Console.WirteLine(52.0);

        // ¹®ÀÚ(Character)
        Console.WirteLine('A');
        Console.WirteLine('°¡');

        // ¹®ÀÚ¿­(string) ¼Ò¹®ÀÚ s½á¾ßÇÔ. ÁÖÀÇ
        Console.WirteLine("Hello World");
        // Escape CharacterÅ»Ãâ ¹®ÀÚ
        Console.WirteLine("¹Ì\n\n¸²\t\"°í");

        // ¹®ÀÚ¿­ ¿¬°á ¿¬»êÀÚ(Concatenation Operator)
        Console.WirteLine("Hello" + " " + "World");

        // ¹®ÀÚ¿­ ÀÎµ¦½º Á¢±Ù [ ]
        Console.WirteLine("Hello World"[4]); // "o" Ãâ·Â (¹è¿­Ã³·³ Ãë±Þ)
        Console.WirteLine("Hello World"[100]); // ¿¹¿Ü ¹ß»ý
        Console.WirteLine("Hello World"[-3]); // ¿¹¿Ü ¹ß»ý

        // ÁÖÀÇ
        Console.WirteLine('°¡' + 'ÆR'); // ¼ýÀÚ Ãâ·Â, Ä³¸¯ÅÍ´Â ±âº»ÀûÀ¸·Î Á¤¼ö·Î Ãë±ÞµÇ±â ¶§¹®¿¡ Àú µÑÀ» ´õÇÑ ¼ýÀÚ·Î ³ª¿È.
        Console.WirteLine("" + '°¡' + 'ÆR'); // °¡ÆR Ãâ·Â, ¹®ÀÚ¿­·Î ÇÒ¶ó¸é ÀÌ·±½ÄÀ¸·Î(¹®ÀÚ¿­ µÚ´Â ¹®ÀÚ¿­Ãë±ÞµÊ)

        // ³í¸®
        Console.WirteLine(true);
        Console.WirteLine(false);

        // ºñ±³ ¿¬»êÀÚ(Compar ison operator)
        // == != > < >= <=

        // ³í¸® ¿¬»êÀÚ(Logical Operator)
        // && || ! - and or not

        // #1 12-4. º¯¼ö
        string s = "¹®ÀÚ¿­ ÀÚ·áÇü";

        // #1 12-5 º¹ÇÕ´ëÀÔ¿¬»êÀÚ
        // += -= *= /=
        string output = "Hello";
        output += "World";
        Conole.WriteLine(output);

        // #1 12-6 Áõ°¨ ¿¬»êÀÚ
        int number = 10;
        Console.WirteLine(number); // 10
        Console.WirteLine(++number); // 12
        Console.WirteLine(number--); // 12
        Console.WirteLine(--number); // 10

        // #1 12-8 var Å°¿öµå (7»ý·«ÇÔ)
        var vernumber = 20;
        // var abc; // X ¹Ýµå½Ã ÃÊ±âÈ­ ÇØÁà¾ß ÇÔ

        // #1 12-9 ÀÔ·Â
        string input = Console.ReadLine();

        // #1 12-10 ÀÚ·áÇü º¯È¯
        // ±²ÀåÈ÷ Áß¿ä
        
        // #2 13-1 if Á¶°Ç¹® (°ýÈ£¸¦ ¿·ÀÌ ¾Æ´Ñ ¾Æ·¡·Î ½á¾ßÇÑ´Ù.)
        if(true)
        {
            
        }
        else if(true)
        {
            
        }
        else
        {

        }
        
        // #2 13-5 switch Á¶°Ç¹®
        switch (condition)
        {
            case 0:
                //
                break:
            default:
                // 
                break:
        }

        // #2 13-6 »ïÇ× ¿¬»êÀÚ
        Console.WirteLine(number %2 == - ? true : false);

        // #3 14-1 ¹Ýº¹¹®°ú ¹è¿­
        int[] intArray = new int[100];
        Console.WriteLine(intArray[99]);

        // #3 14-2 while ¹Ýº¹¹®
        int i = 0;
        int[] intArrayy2 = { 52, 273, 32 };
        while(i < intArrayy2.Length)
        {
            Console.WriteLine(intArray2[i]);
            i++; // Å»ÃâÀ» À§ÇÑ º¯¼ö
        }

        // #3 14-6 foreach ¹Ýº¹¹®
        string[] foreachArray = { "»ç°ú", "¹è", "Æ÷µµ" };
        foreach(var item in foreachArray)
        {
            Console.WriteLine(item);
        }

        // #4 21-2 Å¬·¡½º »ý¼º
        Random random = new Random();
        Console.WriteLine(random.Next());

        Console.WriteLine(Math.Abs(-9)); // 9
        Console.WriteLine(Math.Ceiling(42.3));

        // #4 21-4 ÀÎ½ºÅÏ½º º¯¼ö
        User user1 = new User();
        user1.name = "ÀÌ¹Ì¸²";
        user1.phoneN = "010-0000-0000";

        Product p1 = new Product();
        p1.name = "¾î¸¥Æù";
        p1.price = 99999999;

        Product p2 = new Product()
        {
            name = "°¨ÀÚÆù", price = 3000
        };

        Console.WriteLine(Product.TAX_RATIO);
        Console.WriteLine(p1.TAX_RATIO); // JAVA´Â °¡´ÉÇÏ³ª C#Àº ºÒ°¡

    }
}