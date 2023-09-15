export interface ApiResponse {
  statusCode: number;
  messages?: Array<{ messageType: string; message: string }>;
  success: boolean;
  content?: any;
}
