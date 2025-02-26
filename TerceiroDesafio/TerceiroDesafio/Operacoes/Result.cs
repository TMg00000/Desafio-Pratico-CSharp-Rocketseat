namespace TerceiroDesafio.Operacoes;

using System;
public class Result
{
    public (double mult, double adicao, double sub, double div, double media) AllResult()
    {
        var getNum = new GetNum().GetNumUsers();

        var mult = new Mult().ResultMult(getNum.numOne,getNum.numTwo);
        var adicao = new Adicao().ResultAdicao(getNum.numOne, getNum.numTwo);
        var sub = new Subtracao().ResultSubtracao(getNum.numOne, getNum.numTwo);
        var div = new Divisao().ResultDivisao(getNum.numOne, getNum.numTwo);
        var media = new Media().ResultMedia(getNum.numOne, getNum.numTwo);

        return (mult, adicao, sub, div, media);
    }
}