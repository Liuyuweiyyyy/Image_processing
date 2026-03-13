#include "pch.h"
extern "C" __declspec(dllexport)
void inverse90(unsigned char* img, int w, int h, int byteDepth)
{
    int* dst = new int[w * h * byteDepth];

    for (int y = 0; y < h; y++)
    {
        for (int x = 0; x < w; x++)
        {
            for (int c = 0; c < byteDepth; c++)
            {
                dst[((w - x - 1) * h + y) * byteDepth + c] = img[(y * w + x) * byteDepth + c];
            }
        }
    }

    for (int i = 0; i < w * h * byteDepth; i++)
        img[i] = dst[i];

    delete[] dst;
}