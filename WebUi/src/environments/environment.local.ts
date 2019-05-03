const baseUrl = 'http://localhost:58248/api/';
const scoreUrl = baseUrl + 'Score';
const allScoresUrl = scoreUrl + '/All';

export const environment = {
  production: false,
  baseUrl: baseUrl,
  scoreUrl: scoreUrl,
  allScoresUrl: allScoresUrl
};