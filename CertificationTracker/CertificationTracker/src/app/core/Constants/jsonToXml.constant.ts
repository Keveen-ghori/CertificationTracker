export function jsonToXml(json: any) {
  let xml = '<DataItems>';
  for (let i = 0; i < json.length; i++) {
    xml += '<DataItem>';
    for (const key in json[i]) {
      xml += `<${key}>${json[i][key]}</${key}>`;
    }
    xml += '</DataItem>';
  }
  xml += '</DataItems>';
  return xml;
}
