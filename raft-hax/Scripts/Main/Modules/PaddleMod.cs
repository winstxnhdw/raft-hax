using System.Collections;
using UnityEngine;
using Steamworks;

namespace Hax;
public class PaddleMod : HaxModules {
    Coroutine paddleCoroutine;

    protected override void OnEnable() {
        base.OnEnable();
        InputListener.onF10Press += this.Paddle;

    }

    protected override void OnDisable() {
        base.OnDisable();
        InputListener.onF10Press -= this.Paddle;
    }

    void Paddle() {
        if (this.paddleCoroutine != null) {
            StopCoroutine(this.paddleCoroutine);
            this.paddleCoroutine = null;
            return;
        }

        Network_Player networkPlayer = ComponentManager<Network_Player>.Value;
        Message_Paddle messagePaddle = new Message_Paddle(Messages.Paddle, networkPlayer, Vector3.zero, networkPlayer.transform.forward, 100.0f);
        this.paddleCoroutine = StartCoroutine(this.PaddleCoroutine(networkPlayer, messagePaddle));
    }

    IEnumerator PaddleCoroutine(Network_Player networkPlayer, Message_Paddle messagePaddle) {
        while (true) {
            for (int i = 0; i < 10; i++) networkPlayer.SendP2P(messagePaddle, EP2PSend.k_EP2PSendReliable, NetworkChannel.Channel_Game);
            yield return null;
        }
    }
}