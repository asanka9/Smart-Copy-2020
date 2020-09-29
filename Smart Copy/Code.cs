using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Copy
{
    class Code
    {
        private String element_1;
        private String element_2;
        //private String element_3;
        //private String element_4;
        private String raw; 

        //Output Operation
        private int clicked = 0;
        private int numeric_operation = 0;
        private int list_operation = 0;

        private List<String> sentences = new List<String>();
        private List<IDictionary<String, int[]>> numbers = new List<IDictionary<String, int[]>>();
        private List<String> list = new List<String>();
        private List<Char> operations = new List<char>();

        String output = "";

        public Code(String raw, String element_1, String element_2, List<String> string_list)
        {
            this.raw = raw;
            this.element_1 = element_1;
            this.element_2 = element_2;
            //this.element_3 = element_3;
            //this.element_4 = element_4;
            this.list = string_list;
            ProcessData2Lists();
        }

        private String MainOperation()
        {
            String output = "";
            for (int i = 0 + 1; i < this.operations.Count + 1; i++)
            {
                String temp = "";
                if (this.operations[i - 1] == 'N')
                {
                    IDictionary<String, int[]> temp_dic = this.numbers[this.numeric_operation];
                    foreach (var kvp in temp_dic)
                    {
                        String operation = kvp.Key;
                        int value_01 = kvp.Value[0];
                        int value_02 = kvp.Value[1];
                        switch (operation)
                        {
                            case "*":
                                int a = value_01;
                                for (int j = 0; j < clicked; j++)
                                {

                                    a = a * value_02;
                                }
                                temp = a.ToString();
                                break;
                            case "+":
                                int a1 = value_01;
                                for (int j = 0; j < clicked; j++)
                                {
                                    a1 = a1 + value_02;

                                }
                                temp = a1.ToString();
                                break;
                            case "/":
                                int a2 = value_01;
                                for (int j = 0; j < clicked; j++)
                                {
                                    a2 = a2 / value_02;
                                }
                                temp = a2.ToString();
                                break;
                            case "%":
                                int a3 = value_01;
                                for (int j = 0; j < clicked; j++)
                                {
                                    a3 = a3 % value_02;
                                }
                                temp = a3.ToString();
                                break;
                        }
                        // temp = value_01.ToString();
                    }
                    this.numeric_operation++;
                }
                else
                {
                    temp = this.list[this.list_operation];
                    this.list_operation++;
                }
                output = output + sentences[i - 1] + temp;
            }
            output = output + this.sentences[this.sentences.Count - 1];
            return output;
        }

        public String ClickOnCopy()
        {
            this.numeric_operation = 0;
            this.clicked++;
            return MainOperation();
        }

        private void ProcessData2Lists()
        {
            String raw = this.raw;
            int startIndex = 0;
            String element_1 = this.element_1;
            String element_2 = this.element_2;
            //String element_3 = this.element_3;
            //String element_4 = this.element_4;
            int index_1 = 0;
            int index_2 = 0;

            String raw_final = "";
            int element_count = -1;
            int a = 0;
            while (true)
            {
                index_1 = raw.IndexOf(element_1);
                index_2 = raw.IndexOf(element_2);
                //index_3 = raw.IndexOf(element_3);
                // index_4 = raw.IndexOf(element_4);
                if (index_1 == -1 && index_2 == -1)
                {
                    raw_final = raw;
                    break;
                }
                else
                {
                    List<int> temp = new List<int>();
                    element_count++;
                    if (index_1 > 0) { temp.Add(index_1); };
                    if (index_2 > 0) { temp.Add(index_2); };

                    int min = raw.Length;
                    foreach (int i in temp)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                    int endIndex = min;
                    int length = endIndex - startIndex;
                    string piece = raw.Substring(startIndex, length);
                    if (a % 2 == 0)
                    {
                        this.sentences.Add(piece);
                    }
                    a++;
                    raw = raw.Substring(length + 2);
                    if (element_count % 2 == 0)
                    {
                        String co = raw.Split()[1];
                        String[] temp_Arr = { "+", "-", "/", "*" };
                        bool numbers_list = false;
                        for (int i = 0; i < temp_Arr.Length; i++)
                        {
                            int found_inde = co.IndexOf(temp_Arr[i]);
                            if (found_inde != -1)
                            {
                                numbers_list = true;
                                break;
                            }
                        }
                        if (numbers_list)
                        {
                            String code = co;
                            String[] tempArr = { "+", "-", "/", "*" };
                            int found_operation = 0;
                            int found_index = 0;
                            for (int i = 0; i < tempArr.Length; i++)
                            {
                                found_index = code.IndexOf(tempArr[i]);
                                if (found_index != -1)
                                {
                                    found_operation = i;
                                    break;
                                }
                            }
                            int startInde = 0;
                            int endInde = found_index;
                            int lengt = endInde - startInde;
                            string piece01 = code.Substring(startInde, lengt);
                            int startIndex1 = endInde + 1;
                            int endIndex1 = code.Length;
                            int length1 = endIndex1 - startIndex1;
                            string piece02 = code.Substring(startIndex1, length1);
                            int[] temp0 = { Int32.Parse(piece01), Int32.Parse(piece02) };
                            IDictionary<string, int[]> myDict = new Dictionary<string, int[]>();
                            myDict.Add(tempArr[found_operation], temp0);
                            numbers.Add(myDict);
                            operations.Add('N');
                        }
                        else
                        {
                            operations.Add('L');
                        }
                    }
                    raw_final = raw;
                }
            }
            this.sentences.Add(raw_final);
        }
    }
}
