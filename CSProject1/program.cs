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


        



    }
}