"use strict";

const porta = 3000;
const express = require("express");
const derp = require("derive-password-bytes");
const Rijndael = require("rijndael-js");
const date = require("date-and-time");
const MemoryStream = require("memorystream");
const app = express();

app.get("/gerartoken/:token", function (req, res, next) {
  //token => pRmLaEr7L&m3YBznM&Mu
  var tokenGerado = "";
  let tokenInterno = req.params.token;
  let bytes = Buffer.from(tokenInterno.length.toString(), "ascii");
  const deriveBytes = derp(tokenInterno, bytes, 1, "sha1", 32);
  const encripitador = new Rijndael(deriveBytes, "cbc");

  var memStream = new MemoryStream();
  let bytesData = Buffer.from(date.format(new Date(), "ddMMyyyyHHmm"));

  const ciphertext = Buffer.from(encripitador.encrypt(tokenInterno, 256, iv));
 
  ciphertext.toString("base64");

  memStream.write(bytesData);
  memStream.write(encripitador.key.toString('ascii'));
  memStream.end('!');

  tokenGerado = Buffer.from(memStream.toString(), 'base64').toString('ascii');

  res.status(200).send({
    title: "Token Gerado",
    token: tokenGerado,
  });
});

app.listen(porta, (req, res) => {
  console.log("servidor On");
});
