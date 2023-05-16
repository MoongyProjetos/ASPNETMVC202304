function OlaMundoComplicada(mensagem) {
  let text;
  if (confirm(mensagem) == true) {
    text = "You pressed OK!";
  } else {
    text = "You canceled!";
  }

  alert(text);
}
