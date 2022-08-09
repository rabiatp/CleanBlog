const express = require('express')
const app = express()
const path = require('path')
let ejs = require('ejs')


app.use(express.static('public'))

app.set('view engine', 'ejs');

app.get('/', (req, res) => {
  res.render('index')
})
app.get('/about.html', (req, res) => {
  res.render('about')
})
app.get('/add_post.html', (req, res) => {
  res.render('add_post')
})
app.get('/index.html', (req, res) => {
  res.render('index')
})

const port = 3000

app.listen(port, () => {
    console.log(`Sunucu ${port} bağlantı kuruldu`)
})