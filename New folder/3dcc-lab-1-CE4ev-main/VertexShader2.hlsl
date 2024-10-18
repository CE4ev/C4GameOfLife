// an ultra simple hlsl vertex shader
struct VERTEX
{
    float2 pos : POSITION;
    float4 color : COLOR;
};

struct VERTEX_OUT
{
    float4 pos : SV_POSITION;
    float4 color : COLOR;
};

VERTEX_OUT main(VERTEX input)
{
    VERTEX_OUT output;
    output.pos = float4(input.pos, 0, 1);
    output.color = input.color;
    return output;
}