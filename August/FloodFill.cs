
// 733. 图像渲染

/*
有一幅以二维整数数组表示的图画，每一个整数表示该图画的像素值大小，数值在 0 到 65535 之间。

给你一个坐标 (sr, sc) 表示图像渲染开始的像素值（行 ，列）和一个新的颜色值 newColor，让你重新上色这幅图像。

为了完成上色工作，从初始坐标开始，记录初始坐标的上下左右四个方向上像素值与初始坐标相同的相连像素点，接着再记录这四个方向上符合条件的像素点与他们对应四个方向上像素值与初始坐标相同的相连像素点，……，重复该过程。将所有有记录的像素点的颜色值改为新的颜色值。

最后返回经过上色渲染后的图像。
*/

public class Solution {
    private int Origin;
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        Origin = image[sr][sc];
        //Console.WriteLine(image.Length);
        if (Origin != newColor)
        {
            dfs(image, sr, sc, newColor);
        }
        return image;
    }

    public void dfs(int[][] img,int sr,int sc,int newColor)
    {
        if (sr<0||sr>=img.Length||sc<0||sc>=img[0].Length||img[sr][sc] != Origin)
        {
            return;
        }
        img[sr][sc] = newColor;
        dfs(img, sr + 1, sc, newColor);
        dfs(img, sr - 1, sc, newColor);
        dfs(img, sr, sc + 1, newColor);
        dfs(img, sr, sc - 1, newColor);
    }
}