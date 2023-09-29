export interface Confirmation {
  message: string;
  accept: () => void;
  reject?: () => void;
}
