using System.Linq;
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
    string solution(string s)
    {
        string answer = "";
        char[] arr = s.ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        answer = new string(arr);
        return answer;
    }
}