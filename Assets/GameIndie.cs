using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameIndie : MonoBehaviour
{
    public InputField input_nome_jogador_1;
    public InputField input_numero_jogador_1;
    public InputField input_ParImpar_jogador_1;

    public Text input_ParImpar_jogador_2;
    public Text texto_vencedor;

    string numero_player_1;
    string par_impar_player_1;

    string numero_player_2;

    public void jogar() {

        numero_player_1 = input_numero_jogador_1.text;
        numero_player_2 = SortearNumeroPlayer2();

        int int_numero_player_1 = int.Parse(numero_player_1);
        int int_numero_player_2 = int.Parse(numero_player_2);

        int resultado = int_numero_player_1 + int_numero_player_2;

        string imparOuPar = ImparPar(resultado);

        input_ParImpar_jogador_2.text = numero_player_2;


        string parImparJogador1 = input_ParImpar_jogador_1.text.ToLower();
        ValidaResultado(imparOuPar, parImparJogador1);

    }

    string SortearNumeroPlayer2()
    {
        int numero_aleatorio = Random.Range(0, 10);
        return numero_aleatorio.ToString();
    }

    string ImparPar(int resultado) {

        return resultado % 2 == 0 ? "par" : "impar";

    }

    void ValidaResultado(string ImparOuPar, string input_ParImpar_jogador_1)
    {
        if (ImparOuPar == input_ParImpar_jogador_1) { 
            
            texto_vencedor.text = "O jogador 1 venceu";
        }

        if (ImparOuPar != input_ParImpar_jogador_1)
        {

            texto_vencedor.text = "O jogador 2 venceu";
        }

    }
}
