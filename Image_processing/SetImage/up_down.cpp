#include "pch.h"
extern "C" __declspec(dllexport)
void up_down(int* img, int w, int h)
{
    int* dst = new int[h * w];
    for (int y = 0; y < h; y++)
        for (int x = 0; x < w; x++)
            dst[(w - 1 - y) * w + x] = img[y * w + x];

    for (int i = 0; i < w * h; i++)
        img[i] = dst[i];

    delete[] dst;
}