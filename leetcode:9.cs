using System;
public class Solution
{
    public static void Main()
    {
        Console.WriteLine(RobotSim([6, -1, -1, 6], [[0, 0]]));
    }
    public static int RobotSim(int[] commands, int[][] obstacles)
    {
        //北,東,南,西
        int[,] directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        int nowX = 0, nowY = 0;
        
        //紀錄現在面對的方向
        int nowDirectionIndex = 0;
        //紀錄現在最大距離
        int answer = 0;

        //將障礙物位置資訊紀錄
        HashSet<(int, int)> valuePairs = [];
        foreach (var value in obstacles) 
        {
            valuePairs.Add((value[0], value[1]));
        }

        //進行命令
        foreach (int command in commands) 
        {
            //右轉
            if (command == -1) 
            {
                nowDirectionIndex = (nowDirectionIndex + 1) % 4;
            }
            //左轉
            else if (command == -2) 
            {
                nowDirectionIndex = (nowDirectionIndex + 3) % 4;
            }
            //朝面對方向移動
            else 
            {
                //一次進行一單位移動，檢查是否有障礙物
                for (int i = 0; i < command; i++) 
                {
                    int newX = nowX + directions[nowDirectionIndex, 0];
                    int newY = nowY + directions[nowDirectionIndex, 1];

                    //沒有遇到障礙物
                    if (!valuePairs.Contains((newX, newY)))
                    {
                        answer = Math.Max(answer, newY * newY + newX * newX);
                        nowX = newX;
                        nowY = newY;
                    }
                    //遇到障礙物
                    else
                        break;
                }

            }
        }

        return answer;
    }
}
