using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using CommunityToolkit.HighPerformance;

namespace AlgoLab;

[PlainExporter]
[HtmlExporter]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByMethod, BenchmarkLogicalGroupRule.ByParams)]
[MemoryDiagnoser(false)]
public class Benchy
{
    private readonly int _n = (int)Math.Pow(2, 13);

    [Params(0, 1, Priority = 1)] 
    public int FillType { get; set; }

    [Params(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, Priority = 2)]
    public int X { get; set; }

    private int _target;
    private int _m;

    private int[,] _matrix = null!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _m = (int)Math.Pow(2, X);
        _matrix = new int[_m, _n];
        for (var i = 0; i < _m; i++)
        for (var j = 0; j < _n; j++)
            _matrix[i, j] = FillType switch
            {
                0 => (_n / _m * i + j) * 2,
                1 => _n / _m * i * j * 2,
                _ => throw new NotImplementedException()
            };
        _target = FillType switch
        {
            0 => 2 * _n + 1,
            1 => 16 * _n + 1,
            _ => throw new NotImplementedException()
        };
    }

    [Benchmark]
    public bool LadderSearch()
    {
        var i = 0;
        var j = _n - 1;
        while (i < _m && j > 0)
        {
            if (_matrix[i, j] == _target) return true;
            if (_matrix[i, j] > _target)
            {
                j--;
                continue;
            }

            i++;
        }

        return false;
    }

    [Benchmark]
    public bool BinarySearch()
    {
        Span2D<int> m = _matrix;
        for (var i = 0; i < _m; i++)
        {
            var l = 0;
            if (SearchHelpers.BinarySearch(m.GetRowSpan(i), _target, ref l, _n - 1))
                return true;
        }

        return false;
    }

    [Benchmark]
    public bool ExponentialSearch()
    {
        var l = 0;
        Span2D<int> m = _matrix;
        for (var i = 0; i < _m; i++)
        {
            var row = m.GetRowSpan(i);
            var step = 1;
            var r = l + step;
            while (r < _n && row[r] < _target)
            {
                l += step;
                step *= 2;
                r = l + step;
            }
            r = r >= _n ? _n - 1 : r;
            if (row[r] == _target) return true;
            if (SearchHelpers.BinarySearch(row, _target, ref l, r)) return true;
        }

        return false;
        
    }
}

public static class SearchHelpers
{
    public static bool BinarySearch(Span<int> a, int target, ref int l, int r)
    {
        while (l <= r)
        {
            var m = (l + r) / 2;
            if (a[m] == target) return true;
            if (a[m] < target) l = m + 1;
            else r = m - 1;
        }

        return false;
    }
}