using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class MazeGeneratorTests
    {
        //Tests for MazeGenerator.GenerateMaze
        private MazeGenerator _mazeGenerator = new MazeGenerator();

        // [Test]
        // public void GenerateMaze_Return_Maze_WhenRowsColsThreshPositive()
        // {
        //     var maze = _mazeGenerator.GenerateMaze(30, 30, 0.5f);
        //     Assert.That(maze, !Is.Null);
        // }

        [Test]
        public void GenerateMaze_Return_Null_WhenRowsLessThanThree()
        {
            var maze = _mazeGenerator.GenerateMaze(2, 30, 0.5f);
            Assert.That(maze, Is.Null);
        }

        [Test]
        public void GenerateMaze_Return_Null_WhenColsLessThanThree()
        {
            var maze = _mazeGenerator.GenerateMaze(30, 2, 0.5f);
            Assert.That(maze, Is.Null);
        }

        [Test]
        public void GenerateMaze_Return_Null_WhenThreshNegative()
        {
            var maze = _mazeGenerator.GenerateMaze(30, 30, -0.5f);
            Assert.That(maze, Is.Null);
        }

        [Test]
        public void GenerateMaze_Return_Null_WhenRowsColsThreshNegative()
        {
            var maze = _mazeGenerator.GenerateMaze(-30, -30, -0.5f);
            Assert.That(maze, Is.Null);
        }
    }
}