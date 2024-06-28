internal class Program
{
    static void Main(string[] args)
    {
        var abc = 3;

        // �����ּ�
        /* ������ �ּ� */
        /*** XML �ּ� ***/

        // #1 12-3. �⺻ �ڷ���
        Console.WriteLine(52 + 4 - 1);
        // ��Ģ������ = ��� ���� = Arithmetic Operator
        // + - * / %

        // �Ǽ�(Real Number)
        Console.WirteLine(52.0);

        // ����(Character)
        Console.WirteLine('A');
        Console.WirteLine('��');

        // ���ڿ�(string) �ҹ��� s�����. ����
        Console.WirteLine("Hello World");
        // Escape CharacterŻ�� ����
        Console.WirteLine("��\n\n��\t\"��");

        // ���ڿ� ���� ������(Concatenation Operator)
        Console.WirteLine("Hello" + " " + "World");

        // ���ڿ� �ε��� ���� [ ]
        Console.WirteLine("Hello World"[4]); // "o" ��� (�迭ó�� ���)
        Console.WirteLine("Hello World"[100]); // ���� �߻�
        Console.WirteLine("Hello World"[-3]); // ���� �߻�

        // ����
        Console.WirteLine('��' + '�R'); // ���� ���, ĳ���ʹ� �⺻������ ������ ��޵Ǳ� ������ �� ���� ���� ���ڷ� ����.
        Console.WirteLine("" + '��' + '�R'); // ���R ���, ���ڿ��� �Ҷ�� �̷�������(���ڿ� �ڴ� ���ڿ���޵�)

        // ��
        Console.WirteLine(true);
        Console.WirteLine(false);

        // �� ������(Compar ison operator)
        // == != > < >= <=

        // �� ������(Logical Operator)
        // && || ! - and or not

        // #1 12-4. ����
        string s = "���ڿ� �ڷ���";

        // #1 12-5 ���մ��Կ�����
        // += -= *= /=
        string output = "Hello";
        output += "World";
        Conole.WriteLine(output);

        // #1 12-6 ���� ������
        int number = 10;
        Console.WirteLine(number); // 10
        Console.WirteLine(++number); // 12
        Console.WirteLine(number--); // 12
        Console.WirteLine(--number); // 10

        // #1 12-8 var Ű���� (7������)
        var vernumber = 20;
        // var abc; // X �ݵ�� �ʱ�ȭ ����� ��

        // #1 12-9 �Է�
        string input = Console.ReadLine();

        // #1 12-10 �ڷ��� ��ȯ
        // ������ �߿�
        
        // #2 13-1 if ���ǹ� (��ȣ�� ���� �ƴ� �Ʒ��� ����Ѵ�.)
        if(true)
        {
            
        }
        else if(true)
        {
            
        }
        else
        {

        }
        
        // #2 13-5 switch ���ǹ�
        switch (condition)
        {
            case 0:
                //
                break:
            default:
                // 
                break:
        }

        // #2 13-6 ���� ������
        Console.WirteLine(number %2 == - ? true : false);

        // #3 14-1 �ݺ����� �迭
        int[] intArray = new int[100];
        Console.WriteLine(intArray[99]);

        // #3 14-2 while �ݺ���
        int i = 0;
        int[] intArrayy2 = { 52, 273, 32 };
        while(i < intArrayy2.Length)
        {
            Console.WriteLine(intArray2[i]);
            i++; // Ż���� ���� ����
        }

        // #3 14-6 foreach �ݺ���
        string[] foreachArray = { "���", "��", "����" };
        foreach(var item in foreachArray)
        {
            Console.WriteLine(item);
        }

        // #4 21-2 Ŭ���� ����
        Random random = new Random();
        Console.WriteLine(random.Next());

        Console.WriteLine(Math.Abs(-9)); // 9
        Console.WriteLine(Math.Ceiling(42.3));

        // #4 21-4 �ν��Ͻ� ����
        User user1 = new User();
        user1.name = "�̸̹�";
        user1.phoneN = "010-0000-0000";

        Product p1 = new Product();
        p1.name = "���";
        p1.price = 99999999;

        Product p2 = new Product()
        {
            name = "������", price = 3000
        };

        Console.WriteLine(Product.TAX_RATIO);
        Console.WriteLine(p1.TAX_RATIO); // JAVA�� �����ϳ� C#�� �Ұ�

    }
}