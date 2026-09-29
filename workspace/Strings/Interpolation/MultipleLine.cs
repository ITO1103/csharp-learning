// 式を複数行にまたがって記述する

int[] numbers = [3, 1, 4, 1, 5, 9, 2, 6];
Console.WriteLine($"Total: { // {}で括れば複数行に跨って式を記述できる
        numbers.Sum()
        }, average: {numbers.Average():F2}.");