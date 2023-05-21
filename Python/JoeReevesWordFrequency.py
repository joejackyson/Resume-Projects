import sys
import pickle
import string

def main():
    word_dict = {}
    valid_chars = string.ascii_letters + string.digits + "'"
    #source file must be called Alice.txt for this code to work
    with open('Alice.txt', 'r', encoding='utf-8') as f:
        lines = f.readlines()[29:3372]
        
    
    for line in lines:
        for word in line.split():
            the_string = "".join(ch for ch in word if ch in valid_chars)
            the_string = the_string.lower()
            if the_string not in word_dict:
                word_dict[the_string] = 0
            word_dict[the_string] += 1
    output_file = open('AliceOutput.txt', 'w')

    for k, v in sorted(word_dict.items(), key=lambda item:item[1], reverse = True):
        key_value = k + ' ' + str(v)
        output_file.write(key_value + '\n')

    output_file.close()
    f.close

    f = open('AlicePickled.bin', 'wb')
    pickle.dump(word_dict, f)
    f.close

    # opening alice pickled file
    f = open("AlicePickled.bin", 'rb')
    my_dict = pickle.load(f)
    f.close

    #printing pickled file
    counter = 0
    for k, v in sorted(my_dict.items(), key=lambda item:item[1], reverse = True):
       print(k, ' ', v)
       counter += 1
       if counter > 50:
           break



if __name__ == "__main__":
    main()
