const baseUrl = 'http://localhost:82/api/';
const scoreUrl = baseUrl + 'Score';
const allScoresUrl = scoreUrl + '/All';

export const environment = {
  production: false,
  baseUrl: baseUrl,
  scoreUrl: scoreUrl,
  allScoresUrl: allScoresUrl
};