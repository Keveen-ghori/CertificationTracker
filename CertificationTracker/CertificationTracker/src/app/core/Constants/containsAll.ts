export function containsAll(
  needles: any[],
  haystack: { pkid: number }[]
): boolean {
  let isContainsAll = true;
  const haystackPKID: number[] = [];

  for (let i = 0; i < haystack.length; i++) {
    haystackPKID.push(haystack[i].pkid);
  }

  for (let j = 0; j < needles.length; j++) {
    if (haystackPKID.indexOf(needles[j].pkid) < 0) {
      isContainsAll = false;
      break;
    }
  }

  return isContainsAll;
}
