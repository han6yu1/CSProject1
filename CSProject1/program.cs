internal class Program
{
    static void Main(string[] args)
    {
        var abc = 3;

        // 한줄주석
        /* 여러줄 주석 */
        /*** XML 주석 ***/

        // #1 12-3. 기본 자료형
        Console.WriteLine(52 + 4 - 1);
        // 사칙연산자 = 산술 연산 = Arithmetic Operator
        // + - * / %

        // 실수(Real Number)
        Console.WirteLine(52.0);

        // 문자(Character)
        Console.WirteLine('A');
        Console.WirteLine('가');

        // 문자열(string) 소문자 s써야함. 주의
        Console.WirteLine("Hello World");
        // Escape Character탈출 문자
        Console.WirteLine("미\n\n림\t\"고");

        // 문자열 연결 연산자(Concatenation Operator)
        Console.WirteLine("Hello" + " " + "World");

        // 문자열 인덱스 접근 [ ]
        Console.WirteLine("Hello World"[4]); // "o" 출력 (배열처럼 취급)
        Console.WirteLine("Hello World"[100]); // 예외 발생
        Console.WirteLine("Hello World"[-3]); // 예외 발생

        // 주의
        Console.WirteLine('가' + '힣'); // 숫자 출력, 캐릭터는 기본적으로 정수로 취급되기 때문에 저 둘을 더한 숫자로 나옴.
        Console.WirteLine("" + '가' + '힣'); // 가힣 출력, 문자열로 할라면 이런식으로(문자열 뒤는 문자열취급됨)

        // 논리
        Console.WirteLine(true);
        Console.WirteLine(false);

        // 비교 연산자(Compar ison operator)
        // == != > < >= <=

        // 논리 연산자(Logical Operator)
        // && || ! - and or not

        // #1 12-4. 변수
        string s = "문자열 자료형";

        // #1 12-5 복합대입연산자
        // += -= *= /=
        string output = "Hello";
        output += "World";
        Conole.WriteLine(output);

        // #1 12-6 증감 연산자
        int number = 10;
        Console.WirteLine(number); // 10
        Console.WirteLine(++number); // 12
        Console.WirteLine(number--); // 12
        Console.WirteLine(--number); // 10

        // #1 12-8 var 키워드 (7생략함)
        var vernumber = 20;
        // var abc; // X 반드시 초기화 해줘야 함

        // #1 12-9 입력
        string input = Console.ReadLine();

        // #1 12-10 자료형 변환
        // 굉장히 중요
        
        // #2 13-1 if 조건문 (괄호를 옆이 아닌 아래로 써야한다.)
        if(true)
        {
            
        }
        else if(true)
        {
            
        }
        else
        {

        }
        
        // #2 13-5 switch 조건문
        switch (condition)
        {
            case 0:
                //
                break:
            default:
                // 
                break:
        }

        // #2 13-6 삼항 연산자
        Console.WirteLine(number %2 == - ? true : false);

        // #3 14-1 반복문과 배열
        int[] intArray = new int[100];
        Console.WriteLine(intArray[99]);

        // #3 14-2 while 반복문
        int i = 0;
        int[] intArrayy2 = { 52, 273, 32 };
        while(i < intArrayy2.Length)
        {
            Console.WriteLine(intArray2[i]);
            i++; // 탈출을 위한 변수
        }

        // #3 14-6 foreach 반복문
        string[] foreachArray = { "사과", "배", "포도" };
        foreach(var item in foreachArray)
        {
            Console.WriteLine(item);
        }

        // #4 21-2 클래스 생성
        Random random = new Random();
        Console.WriteLine(random.Next());

        Console.WriteLine(Math.Abs(-9)); // 9
        Console.WriteLine(Math.Ceiling(42.3));

        // #4 21-4 인스턴스 변수
        User user1 = new User();
        user1.name = "이미림";
        user1.phoneN = "010-0000-0000";

        Product p1 = new Product();
        p1.name = "어른폰";
        p1.price = 99999999;

        Product p2 = new Product()
        {
            name = "감자폰", price = 3000
        };

        Console.WriteLine(Product.TAX_RATIO);
        Console.WriteLine(p1.TAX_RATIO); // JAVA는 가능하나 C#은 불가

    }
}