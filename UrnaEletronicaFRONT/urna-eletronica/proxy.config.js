const proxy_config = [
  {
    context: ['/api'],
    target: 'http://localhost:5000',
    secure: false
  }
];

module.exports = proxy_config
