# SlackNotification
Este pluguin permite enviar notificações para canais no Slack.

## Como usar

- 1° Passo: Criar um novo token no Slack, você pode fazer isso [aqui](https://api.slack.com/custom-integrations/legacy-tokens)
- 2° Passo: Veja a [documentação do Slack](https://api.slack.com/methods/chat.postMessage) para entender melhor como funciona o processo, voce pode fazer um teste com o seu token gerado.
- 3° Passo: Adicone o pacote [Nuget](https://www.nuget.org/packages/SlackNotification), faça o seguinte:

```
...
        private readonly ISlackNotificationChannel _slackNotification;

        public SendMessageToChannel(ISlackNotificationChannel slackNotification)
        {
            _slackNotification = slackNotification;

            slackNotification.Register("Seu token", "Seu canal");

            AppDomain.CurrentDomain.FirstChanceException += async (sender, eventArgs) =>
            {
                await slackNotification.SendNotificationAsync("User Name", "Text (Message)");
            };
        }
...

```

## Tecnologias implementadas:

 .NET Core 2.0

### Sobre:
 Desenvolvido por [Mauricio Moccelin](https://www.linkedin.com/in/mauriciomoccelin/) sobre [Licença](https://www.gnu.org/licenses/licenses.pt-br.html).
