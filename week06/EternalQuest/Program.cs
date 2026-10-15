using System;

// Exceeding requirements:
// Added a level system. The player gains levels as they earn points. Every 500 points,
// the player reaches a new level and receive a congratulaations message.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}