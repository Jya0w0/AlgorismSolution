﻿using System.Linq;
using System.Numerics;
// Solution1 두 수의 차
{
    //int solution(int num1, int num2)
    //{
    //    int answer = 0;
    //    answer = num1 - num2;
    //    return answer;
    //}
}

// Solution2 도 수의 곱
{
    //int solution(int num1, int num2)
    //{
    //    int answer = num1 * num2;
    //    return answer;
    //}
}

// Solution3 몫 구하기
{
    //int solution(int num1, int num2)
    //{
    //    int answer = num1 / num2;
    //    return answer;
    //}
}

// Solution4 나이 출력
{
    //int solution(int age)
    //{
    //    int answer = (2022 - age) + 1;
    //    return answer;
    //}
}

// Solution5 숫자 비교하기
{
    //int solution(int num1, int num2)
    //{
    //    int answer = 0;
    //    if (num1 == num2)
    //    {
    //        answer = 1;
    //    }
    //    else
    //    {
    //        answer = -1;
    //    }
    //    return answer;
    //}
}

// Solution6 두 수의 합
{
    //int solution(int num1, int num2)
    //{
    //    int answer = num1 + num2;
    //    Convert.ToDouble(answer);
    //    return answer;
    //}
}

// Solution7 두 수의 나눗셈
{
    //int solution(int num1, int num2)
    //{
    //    double answer = Convert.ToDouble(num1) / num2 * 1000;
    //    return (int)answer;
    //}
}

// Solution8 각도기
{
    //int solution(int angle)
    //{
    //    int answer = 0;
    //    if (0 < angle && angle < 90)
    //    {
    //        answer = 1;
    //    }
    //    else if (angle == 90)
    //    {
    //        answer = 2;
    //    }
    //    else if (angle == 180)
    //    {
    //        answer = 4;
    //    }
    //    else
    //    {
    //        answer = 3;
    //    }
    //    return answer;
    //}
}

// Solution9 짝수의 합
{
    //int solution(int n)
    //{
    //    int answer = 0;
    //    for (int i = 1; i <= n; i++)
    //    {
    //        if (i % 2 == 0)
    //        {
    //            answer += i;
    //        }
    //    }
    //    return answer;
    //}
}

// Solution10 배열의 평균값
{
    //double solution(int[] numbers)
    //{
    //    double answer = 0;
    //    for (int i = 0; i < numbers.Length; i++)
    //    {
    //        answer += (double)numbers[i] / numbers.Length;
    //    }
    //    return answer;
    //}
}

// Solution11 짝수와 홀수
{
    //string solution(int num)
    //{
    //    string answer = "";
    //    if (num % 2 == 0)
    //    {
    //        return "Even";
    //    }
    //    else
    //    {
    //        return "Odd";
    //    }
    //    return answer;
    //}
}


// Solution12 평균 구하기
{
    //double solution(int[] arr)
    //{
    //    double answer = 0;
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        answer += arr[i];
    //    }
    //    return answer /= arr.Length;
    //}
}

// Solution13 자릿수 더하기
{
    //int solution(int n)
    //{
    //    int answer = 0;
    //    char[] c = n.ToString().ToCharArray();
    //    for (int i = 0; i < c.Length; i++)
    //    {
    //        answer += int.Parse(c[i].ToString());
    //    }
    //    return answer;
    //}
}

// Solution14 약수의 합
{
    //int solution(int n)
    //{
    //    int answer = 0;
    //    for (int i = 1; i <= n; i++)
    //    {
    //        if (n % i == 0)
    //        {
    //            answer += i;
    //        }
    //    }
    //    return answer;
    //}
}

// Solution15 나머지가 1이 되는 수 찾기
{
    //int solution(int n)
    //{
    //    int answer = 0;
    //    for (int x = 2; x < n; x++)
    //    {
    //        if (n % x == 1)
    //        {
    //            return answer = x;
    //        }
    //    }
    //    return 0;
    //}
}
// 15 축약버전
{
    //int solution(int n)
    //{
    //    int answer = 0;
    //    for (int x = 2; x < n; x++)
    //        if (n % x == 1) return x;
    //    return 0;
    //}
}

// Solution16 x만큼 간격이 있는 n개의 숫자
{
    //long[] solution(int x, int n)
    //{
    //    long[] answer = new long[n];
    //    {
    //        for (int i = 0; i < n; i++)
    //        {
    //            answer[i] = (long) x * (i + 1); // int로 계산하면 범위 때문에 오버플로
    //        }
    //    }
    //    return answer;
    //}
}

// Solution17 자연수 뒤집어 배열로 만들기
{
    //int[] solution(long n)
    //{
    //    string s = n.ToString();
    //    int[] answer = new int[s.Length];
    //    {
    //        for (int i = s.Length - 1; i >= 0; i--)
    //        {
    //            answer[s.Length - i - 1] = s[i] - '0';
    //        }
    //    }
    //    return answer;
    //}
}

// Solution18 문자열을 정수로 바꾸기
{
    //int solution(string s)
    //{
    //    int answer = int.Parse(s);
    //    return answer;
    //}
}

// Solution19 정수 제곱근 판별
{
    //long solution(long n)
    //{
    //    long i = (long)Math.Sqrt(n);
    //    long answer = 0;
    //    if (Math.Pow(i, 2) == n)
    //    {
    //        answer = (long)Math.Pow(i + 1, 2);
    //    }
    //    else
    //    {
    //        answer = -1;
    //    }
    //    return answer;
    //}
}

// Solution20 정수 내림차순으로 배치하기
{
    //long solution(long n)
    //{
    //    char[] c = n.ToString().ToCharArray();
    //    Array.Sort(c);
    //    long answer = 0;
    //    Array.Reverse(c);
    //    string s = "";
    //    for (long i = 0; i < c.Length; i++)
    //    {
    //        s += c[i];
    //    }
    //    answer = long.Parse(s);
    //    return answer;
    //}
}
// 20 축약버전
{
    //long solution(long n)
    //{
    //    char[] c = n.ToString().ToCharArray();
    //    Array.Sort(c);
    //    Array.Reverse(c);
    //    return long.Parse(c);
    //}
}

// Solution21 하샤드 수
{
    //bool solution(int x)
    //{
    //    char[] c = x.ToString().ToCharArray();
    //    int sum = 0;
    //    for (int i = 0; i < c.Length; i++)
    //    {
    //        sum += int.Parse(c[i].ToString());
    //    }
    //    bool answer = x % sum == 0 ? true : false;
    //    return answer;
    //}
}

// Solution22 두 정수 사이의 합
{
    //long solution(int a, int b)
    //{
    //    long answer = 0;
    //    if (a < b)
    //    {
    //        for (int i = a; i <= b; i++)
    //        {
    //            answer += i;
    //        }
    //    }
    //    else
    //    {
    //        for (int i = b; i <= a; i++)
    //        {
    //            answer += i;
    //        }
    //    }
    //    return answer;
    //}
}

// 22 축약버전
{
    //long solution(int a, int b)
    //{
    //    long answer = 0;
    //    while (a != b)
    //    {
    //        answer += a;
    //        a = (a < b) ? a + 1 : a - 1;
    //    }
    //    return answer + b;
    //}
}

// Solution 23 콜라츠 추측
{
    //int solution(int num)
    //{
    //    int answer = 0;
    //    long a = num;
    //    while (true)
    //    {
    //        if (a == 1)
    //        {
    //            break;
    //        }
    //        else if (answer >= 500)
    //        {
    //            answer = -1;
    //            break;
    //        }
    //        else
    //        {
    //            a = a % 2 == 0 ? a / 2 : a * 3 + 1;
    //            answer++;
    //        }
    //    }
    //    return answer;
    //}
}

// 23 다른버전
{
    //int solution(int num)
    //{
    //    int answer = -1;
    //    long a = num;
    //    for (int i = 0; i < 500; i++)
    //    {
    //        if (a == 1)
    //        {
    //            answer = i;
    //            break;
    //        }
    //        else
    //        {
    //            a = a % 2 == 0 ? a / 2 : a * 3 + 1;
    //        }
    //    }
    //    return answer;
    //}
}

// 24 서울에서 김서방 찾기
{
    //string solution(string[] seoul)
    //{
    //    string answer = "";
    //    int x = Array.IndexOf(seoul, "Kim");
    //    return answer = $"김서방은 {x}에 있다";
    //}
}

// 25 나누어 떨어지는 숫자 배열
{
    //int[] solution(int[] arr, int divisor)
    //{
    //    List<int> result = new List<int>();
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        if (arr[i] % divisor == 0)
    //        {
    //            result.Add(arr[i]);
    //        }
    //    }
    //    if (result.Count == 0)
    //    {
    //        return new int[] { -1 };
    //    }
    //    int[] answer = result.ToArray();
    //    Array.Sort(answer);
    //    return answer;
    //}
}

// 26 음양 더하기
{
    //int solution(int[] absolutes, bool[] signs)
    //{
    //    int answer = 0;
    //    for (int i = 0; i < absolutes.Length; i++)
    //    {
    //        answer += signs[i] == true ? absolutes[i] : -absolutes[i];
    //    }
    //    return answer;
    //}
}

// 27 핸드폰 번호 가리기
{
    //string solution(string phone_number)
    //{
    //    string answer = phone_number.Substring(phone_number.Length - 4, 4);
    //    for (int i = 0; i < phone_number.Length - 4; i++)
    //    {
    //        answer = answer.Insert(i, "*");
    //    }
    //    return answer;
    //}
}

// 28 없는 숫자 더하기
{
    //int solution(int[] numbers)
    //{
    //    int answer = 0;
    //    for (int i = 0; i <= 9; i++)
    //    {
    //        answer += i;
    //    }
    //    return answer -= numbers.Sum();
    //}
}

// 29 제일 작은 수 제거하기
{
//    int[] solution(int[] arr)
//    {
//        int[] answer = new int[] { };
//        if (arr.Length == 1) { arr[0] = -1; return arr; }
//        int min = arr[0];
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (min > arr[i])
//            {
//                min = arr[i];
//            }
//        }
//        List<int> list = new List<int>();
//        list.AddRange(arr);
//        list.Remove(min);
//        answer = list.ToArray();
//        return answer;
//    }
}

// 30 가운데 글자 가져오기
{
    //string solution(string s)
    //{
    //    string answer = "";
    //    int i = s.Length / 2;
    //    answer = s.Length % 2 == 0 ? s.Substring(i - 1, 2) : s.Substring(i, 1);
    //    return answer;
    //}
}

// 31 수박수박수박수박수박수?
{
    //string solution(int n)
    //{
    //    string answer = "";
    //    for (int i = 1; i <= n; i++)
    //    {
    //        answer += i % 2 == 0 ? "박" : "수";
    //    }
    //    return answer;
    //}
}

// 32 내적
{
    //int solution(int[] a, int[] b)
    //{
    //    int answer = 0;
    //    for (int i = 0; i < a.Length; i++)
    //    {
    //        answer += a[i] * b[i];
    //    }
    //    return answer;
    //}
}

// 33 약수의 개수와 덧셈
{
    //int solution(int left, int right)
    //{
    //    int answer = 0;
    //    for (int i = left; i <= right; i++)
    //    {
    //        int count = 0;
    //        for (int j = 1; j <= i; j++)
    //        {
    //            if (i % j == 0)
    //            {
    //                count++;
    //            }
    //        }
    //        answer = count % 2 == 0 ? answer += i : answer -= i;
    //    }
    //    return answer;
    //}
}

// 34 문자열 내림차순으로 배치하기
{
    //string solution(string s)
    //{
    //    string answer = "";
    //    char[] arr = s.ToCharArray();
    //    Array.Sort(arr);
    //    Array.Reverse(arr);
    //    answer = new string(arr);
    //    return answer;
    //}
}

// 35 부족한 금액 계산하기
{
    //long solution(int price, int money, int count)
    //{
    //    long sum = money;
    //    for (int i = 1; i <= count; i++)
    //    {
    //        sum -= (long)price * i;
    //    }
    //    long result = sum < 0 ? sum * -1 : 0;
    //    return result;
    //}
}

// 36 문자열 다루기 기본
{
    //bool solution(string s)
    //{
    //    bool answer = true;
    //    answer = s.Length == 4 || s.Length == 6 ? int.TryParse(s, out int num) : false;
    //    return answer;
    //}
}

// 37 행렬의 덧셈
{
    //int[,] solution(int[,] arr1, int[,] arr2)
    //{
    //    int row = arr1.GetLength(0);
    //    int col = arr1.GetLength(1);
    //    int[,] answer = new int[row, col];
    //    for (int i = 0; i < row; i++)
    //    {
    //        for (int j = 0; j < col; j++)
    //        {
    //            answer[i, j] = arr1[i, j] + arr2[i, j];
    //        }
    //    }
    //    return answer;
    //}
}

// 38 직사각형 별찍기
//    public class Example
//{
//    public static void Main()
//    {
//        String[] s;

//        Console.Clear();
//        s = Console.ReadLine().Split(' ');

//        int a = Int32.Parse(s[0]);
//        int b = Int32.Parse(s[1]);

//        for (int i = 0; i < b; i++)
//        {
//            for (int j = 0; j < a; j++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine();
//        }
//    }
//}

// 39 최대공약수와 최소공배수 ---------
{
    //int[] solution(int n, int m)
    //{
    //    int[] answer = new int[2];
    //    int OriginN = n;
    //    int OriginM = m;
    //    int gcd = 0;
    //    while (m > 0)
    //    {
    //        int temp = n;
    //        n = m;
    //        m = temp % m;
    //        gcd = n;
    //    }
    //    answer[0] = gcd;
    //    answer[1] = OriginN * OriginM / gcd;
    //    return answer;
    //}
}

// 40 3진법 뒤집기
{
    //int solution(int n)
    //{
    //    int answer = 0;
    //    List<int> list = new List<int>();
    //    while (n > 0)
    //    {
    //        int result = n % 3;
    //        list.Add(result);
    //        n /= 3;
    //    }
    //    list.Reverse();
    //    for (int i = 0; i < list.Count; i++)
    //    {
    //        answer += list[i] * (int)Math.Pow(3, i);
    //    }
    //    return answer;
    //}
}

// 40 다른 버전
{
    //int solution(int n) 
    //{
    //    int answer = 0;
    //    while (n > 0)
    //    {
    //        answer *= 3;
    //        answer += n % 3;
    //        n /= 3;
    //    }
    //    return answer;
    //}
}

// 41 이상한 문자 만들기
{
    //string solution(string s)
    //{
    //    string answer = "";
    //    string[] c = s.Split();
    //    for (int i = 0; i < c.Length; i++)
    //    {
    //        for (int j = 0; j < c[i].Length; j++)
    //        {
    //            if (j == 0)
    //            {
    //                answer += Char.ToUpper(c[i][j]);
    //            }
    //            else if (j % 2 == 0)
    //            {
    //                answer += Char.ToUpper(c[i][j]);
    //            }
    //            else
    //            {
    //                answer += Char.ToLower(c[i][j]);
    //            }
    //        }
    //        if (i != c.Length - 1)
    //        {
    //            answer += " ";
    //        }
    //    }

    //    return answer;
    //}
}

// 42 삼총사 ------ 이렇게 풀면 안됨
{
    //int solution(int[] number)
    //{
    //    int answer = 0;
    //    for (int i = 0; i < number.Length; i++)
    //    {
    //        for (int j = i + 1; j < number.Length; j++)
    //        {
    //            for (int k = j + 1; k < number.Length; k++)
    //            {
    //                if (number[i] + number[j] + number[k] == 0)
    //                {
    //                    answer++;
    //                }
    //            }
    //        }
    //    }
    //    return answer;
    //}
}

// 43 크기가 작은 부분 문자열
{
    //int solution(string t, string p)
    //{
    //    int answer = 0;
    //    long numP = long.Parse(p);

    //    for (int i = 0; i <= t.Length - p.Length; i++)
    //    {
    //        long comp = long.Parse(t.Substring(i, p.Length));
    //        if (comp <= numP)
    //        {
    //            answer++;
    //        }
    //    }
    //    return answer;
    //}
}

// 44 최소직각사각형 ------ 능지이슈 다시봐
{
    //int solution(int[,] sizes)
    //{
    //    int answer = 0;
    //    int w = 0;
    //    int h = 0;
    //    for (int i = 0; i < sizes.GetLength(0); i++)
    //    {
    //        if (sizes[i, 0] < sizes[i, 1])
    //        {
    //            int a = sizes[i, 0];
    //            sizes[i, 0] = sizes[i, 1];
    //            sizes[i, 1] = a;
    //        }
    //        if (w < sizes[i, 0])
    //        {
    //            w = sizes[i, 0];
    //        }
    //        if (h < sizes[i, 1])
    //        {
    //            h = sizes[i, 1];
    //        }
    //    }
    //    return answer = w * h;
    //}
}

// 45 시저암호
{
    //string solution(string s, int n)
    //{
    //    string answer = "";
    //    char[] chars = s.ToCharArray();
    //    for (int i = 0; i < chars.Length; i++)
    //    {
    //        if (chars[i] != ' ')
    //        {
    //            int result = chars[i] + n;
    //            if (char.IsLower(chars[i]))
    //            {
    //                if (result > 122)
    //                {
    //                    result -= 26;
    //                }
    //            }
    //            else
    //            {
    //                if (result > 90)
    //                {
    //                    result -= 26;
    //                }
    //            }
    //            answer += Convert.ToChar(result);
    //        }
    //        else
    //        {
    //            answer += ' ';
    //        }
    //    }
    //    return answer;
    //}
}

// 46 숫자 문자열과 영단어
{
    //int solution(string s)
    //{
    //    int answer = 0;
    //    String[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //        s = s.Replace(arr[i], i.ToString());
    //    }
    //    answer = int.Parse(s);
    //    return answer;
    //}
}

// 문자열 내 마음대로 정렬하기
{
    //string[] solution(string[] strings, int n)
    //{
    //    string[] answer = new string[strings.Length];

    //    for (int i = 0; i < strings.Length; i++)
    //    {
    //        answer[i] = strings[i].Substring(n, 1) + strings[i];
    //    }
    //    Array.Sort(answer);

    //    for (int j = 0; j < strings.Length; j++)
    //    {
    //        answer[j] = answer[j].Substring(1);
    //    }

    //    return answer;
    //}
}

// K번째수
{
    //int[] solution(int[] array, int[,] commands)
    //{
    //    int row = commands.GetLength(0);
    //    int[] answer = new int[row];

    //    for (int n = 0; n < row; n++)
    //    {
    //        int i = commands[n, 0] - 1;
    //        int j = commands[n, 1] - 1;
    //        int k = commands[n, 2] - 1;
    //        int len = j - i + 1;

    //        int[] arr = new int[len];
    //        Array.Copy(array, i, arr, 0, len);
    //        Array.Sort(arr);

    //        answer[n] = arr[k];
    //    }


    //    return answer;
    //}
}

// 두 개 뽑아서 더하기
{
    int[] solution(int[] numbers)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int k = numbers[i] + numbers[j];
                if (answer.Contains(k) == false)
                {
                    answer.Add(k);
                }
            }
        }
        answer.Sort();
        return answer.ToArray();
    }
}