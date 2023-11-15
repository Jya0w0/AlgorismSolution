// Solution1 두 수의 차
using System.Numerics;
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
    long[] solution(int x, int n)
    {
        long[] answer = new long[n];
        {
            for (int i = 0; i < n; i++)
            {
                answer[i] = (long) x * (i + 1); // int로 계산하면 범위 때문에 오버플로
            }
        }
        return answer;
    }
}